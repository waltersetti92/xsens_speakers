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

    private static string commonFilePath;
    
    private static string commonFileFolder;
    private string _thisFileFolder;
    public string thisFileFolder { get => commonFileFolder + "_" + _thisFileFolder; set => _thisFileFolder = value; }
    
    private static string commonFileName;
    public string _thisFileName;
    public string thisFileName { get => commonFileName + "_" + _thisFileName; set => _thisFileName = value; }
    public string filExt;

    private string fullFile { get => Path.Combine(new string[] { commonFilePath, thisFileFolder, thisFileName + "." + filExt }); }

    private string[] Header;
    public string headerLine { get => string.Join("\t", Header); }
    private Dictionary<string,string> DataLine = new Dictionary<string,string>();

    public bool KeepStream;

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

    public static void SetCommonPath(string filePath, string folderName, string fileName)
    {
        Logger.commonFileFolder = Path.Combine(new string[] { folderName, fileName,System.DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") });
        Logger.commonFileName = fileName;
        Logger.commonFilePath = filePath;
    }
    public void CreateFolder()
    {
        if (thisFileFolder != "")
        {
            Directory.CreateDirectory(commonFilePath + thisFileFolder);
        }
        else
        {
            Directory.CreateDirectory(commonFilePath);
        }
    }
   
    // Use this for initialization
    public async Task MakeTable() {
        await OpenWriteCloseBye(headerLine, FileMode.Create).ConfigureAwait(false);
    }

    public async Task OpenWriteCloseBye(string text, FileMode fileMode)
    {
        using (FileStream stream = new FileStream(fullFile, fileMode, FileAccess.Write))
        using (StreamWriter writer = new StreamWriter(stream))
        {
            //This is writing the line of the type, name, damage... etc... (I set these)
            await writer.WriteLineAsync(text).ConfigureAwait(false);
        }
    }

    public void SetStream()
    {
        dStream = new FileStream(fullFile, FileMode.Append, FileAccess.Write);
        dWriter = new StreamWriter(dStream);
    }

    public async void logdata()
    {
        
        if (KeepStream)
        {
            if (dWriter == null)
                SetStream();

            await dWriter.WriteLineAsync(DataLine.ToString()).ConfigureAwait(false); ;
            await dWriter.FlushAsync().ConfigureAwait(false); ;
        }
        else
        {
            await OpenWriteCloseBye(DataLine.ToString(), FileMode.Append).ConfigureAwait(false);
        }
    }

    public void SetHeader(string[] columnNames)
    {
        
        foreach(string column in columnNames)
        {
            DataLine.Add(column, null);
        }
    } 

    public void UpdateValue<T>(string variable, T value)
    {
        if (value.GetType() == typeof(float))
        {
            DataLine[variable] = string.Format("{0:0.###}", value);
        }
        else
        {
            DataLine[variable] = value.ToString();
        }
    }

    //This closes the file
    public void StopWriting()
    {
        if (dWriter != null)
        {
            dWriter.Close();
            dStream.Close();
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