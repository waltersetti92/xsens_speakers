using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class LoggerHeader
{
    public string filePath;
    public string fileFolder;
    public string fileName;

    
}


/*
<------------- Logger ------------->

Utilities for data export.
- Define where filepath
- Select what data to export
- write the data to the file
- close file
*/


public class Logger: IDisposable {

    #region members
    private bool _disposedValue;

    static string time;

    private static string commonFilePath;
    
    private static string commonFileFolder;
    private string _thisFileFolder;
    public string thisFileFolder { get => commonFileFolder + "_" + _thisFileFolder; set => _thisFileFolder = value; }
    
    private static string commonFileName;
    private string _thisFileName;
    public string thisFileName
    { get
        {
            return commonFileName + "_" + _thisFileName + (counter==0 ? "":counter.ToString()) ;
        }
        set => _thisFileName = value; }
    public string filExt;

    private string fullFile { get => Path.Combine(new string[] { commonFilePath, thisFileFolder, thisFileName + "." + filExt }); }

    private int counter = 0;

    private Dictionary<string, string> Data = new Dictionary<string, string>();

    
    public string headerLine { get => string.Join("\t", Data.Keys); }
    public string dataLine { get => string.Join("\t", Data.Values); } 

    public readonly bool KeepStream;

    // This is the writer, it writes to the filepath
    Stream dStream;
    StreamWriter dWriter;
    #endregion

    #region Constructors
    public Logger(string destinationFile = "", string destinationFolder = "", string extension = "dat", bool keepStream = false)
    {
        thisFileName = destinationFile;
        thisFileFolder = destinationFolder;
        filExt = extension;
        KeepStream = keepStream;
    }
    #endregion

    #region methods

    public static void SetCommonPath(string filePath, string folderName, string fileName, DateTime? _time = null)
    {
        if (_time == null)
        Logger.time = System.DateTime.Now.ToString("ddMMyyyyHHmmss");
        else
            Logger.time = _time.Value.ToString("ddMMyyyyHHmmss");
        Logger.commonFileFolder = Path.Combine(new string[] { folderName, fileName,Logger.time });
        Logger.commonFileName = Logger.time + "_" + fileName;
        Logger.commonFilePath = filePath;
    }
    public void CreateFolder()
    {
        if (thisFileFolder != "")
        {
            Directory.CreateDirectory(Path.Combine(new string[] { commonFilePath, thisFileFolder }));
        }
        else
        {
            Directory.CreateDirectory(commonFilePath);
        }
    }
   
    // Use this for initialization

    public async Task OpenWriteCloseBye(string text, FileMode fileMode)
    {
        using (FileStream stream = new FileStream(fullFile, fileMode, FileAccess.Write, FileShare.None, bufferSize: 8192, useAsync: true))
        using (StreamWriter writer = new StreamWriter(stream))
        {
            //This is writing the line of the type, name, damage... etc... (I set these)
            await writer.WriteLineAsync(text).ConfigureAwait(false);
        }
    }

    public void SetupDataStream()
    {
        if (!File.Exists(fullFile))
            throw (new IOException("File " +fullFile+ " missing. Set Header first."));
        dStream = new FileStream(fullFile, FileMode.Append, FileAccess.Write, FileShare.None, bufferSize:8192, useAsync: true);
        dWriter = new StreamWriter(dStream);
    }

    public async void LogData()
    {   
        if (KeepStream)
        {
            if (dWriter == null)
                SetupDataStream();

            await dWriter.WriteLineAsync(dataLine).ConfigureAwait(false);
            
            //await dWriter.FlushAsync().ConfigureAwait(false);
        }
        else
        {
            await OpenWriteCloseBye(dataLine, FileMode.Append).ConfigureAwait(false);
        }
    }

    public async Task SetHeader(string[] columnNames)
    {

        Data.Clear();
        
        foreach (string column in columnNames)
        {
            Data.Add(column, "");
        }
        
        try
        {
            await OpenWriteCloseBye(headerLine, FileMode.CreateNew).ConfigureAwait(false);
            counter = 0;
        }
        catch
        {
            counter++;
            if (counter>10)
                throw (new IOException("Unable or unwilling to create another file with the same name") );
            await OpenWriteCloseBye(headerLine, FileMode.CreateNew).ConfigureAwait(false);
        }
        } 

    public void UpdateValue<T>(string variable, T value)
    {
        if (value.GetType() == typeof(float))
        {
            Data[variable] = string.Format("{0:0.###}", value);
        }
        else
        {
            Data[variable] = value.ToString();
        }
    }

    //This closes the file
    public void StopWriting()
    {
        if (dWriter != null)
        {
            Task flusher = Task.Run(()=>dWriter.Flush());
            flusher.Wait();
            dWriter.Close();
            //dStream.Close();
        }
    }

    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose() => Dispose(true);

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                StopWriting();
            }

            _disposedValue = true;
        }
    }
    #endregion
}