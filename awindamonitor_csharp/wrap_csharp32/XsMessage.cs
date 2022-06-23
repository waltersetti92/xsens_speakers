
//  ==> COPYRIGHT (C) 2021 XSENS TECHNOLOGIES OR SUBSIDIARIES WORLDWIDE <==
//  WARNING: COPYRIGHT (C) 2021 XSENS TECHNOLOGIES OR SUBSIDIARIES WORLDWIDE. ALL RIGHTS RESERVED.
//  THIS FILE AND THE SOURCE CODE IT CONTAINS (AND/OR THE BINARY CODE FILES FOUND IN THE SAME
//  FOLDER THAT CONTAINS THIS FILE) AND ALL RELATED SOFTWARE (COLLECTIVELY, "CODE") ARE SUBJECT
//  TO AN END USER LICENSE AGREEMENT ("AGREEMENT") BETWEEN XSENS AS LICENSOR AND THE AUTHORIZED
//  LICENSEE UNDER THE AGREEMENT. THE CODE MUST BE USED SOLELY WITH XSENS PRODUCTS INCORPORATED
//  INTO LICENSEE PRODUCTS IN ACCORDANCE WITH THE AGREEMENT. ANY USE, MODIFICATION, COPYING OR
//  DISTRIBUTION OF THE CODE IS STRICTLY PROHIBITED UNLESS EXPRESSLY AUTHORIZED BY THE AGREEMENT.
//  IF YOU ARE NOT AN AUTHORIZED USER OF THE CODE IN ACCORDANCE WITH THE AGREEMENT, YOU MUST STOP
//  USING OR VIEWING THE CODE NOW, REMOVE ANY COPIES OF THE CODE FROM YOUR COMPUTER AND NOTIFY
//  XSENS IMMEDIATELY BY EMAIL TO INFO@XSENS.COM. ANY COPIES OR DERIVATIVES OF THE CODE (IN WHOLE
//  OR IN PART) IN SOURCE CODE FORM THAT ARE PERMITTED BY THE AGREEMENT MUST RETAIN THE ABOVE
//  COPYRIGHT NOTICE AND THIS PARAGRAPH IN ITS ENTIRETY, AS REQUIRED BY THE AGREEMENT.
//  
//  THIS SOFTWARE CAN CONTAIN OPEN SOURCE COMPONENTS WHICH CAN BE SUBJECT TO 
//  THE FOLLOWING GENERAL PUBLIC LICENSES:
//  ==> Qt GNU LGPL version 3: http://doc.qt.io/qt-5/lgpl.html <==
//  ==> LAPACK BSD License:  http://www.netlib.org/lapack/LICENSE.txt <==
//  ==> StackWalker 3-Clause BSD License: https://github.com/JochenKalmbach/StackWalker/blob/master/LICENSE <==
//  ==> Icon Creative Commons 3.0: https://creativecommons.org/licenses/by/3.0/legalcode <==
//  

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XDA {

public class XsMessage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsMessage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsMessage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsMessage() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsMessage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsMessage(XsXbusMessageId msgId, uint dataLength) : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_0((int)msgId, dataLength), true) {
  }

  public XsMessage(XsXbusMessageId msgId) : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_1((int)msgId), true) {
  }

  public XsMessage() : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_2(), true) {
  }

  public XsMessage(SWIGTYPE_p_unsigned_char source, uint size) : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_3(SWIGTYPE_p_unsigned_char.getCPtr(source), size), true) {
  }

  public XsMessage(XsString source, bool computeChecksum) : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_4(XsString.getCPtr(source), computeChecksum), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsMessage(XsString source) : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_5(XsString.getCPtr(source)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsMessage(XsMessage src) : this(xsensdeviceapiPINVOKE.new_XsMessage__SWIG_6(XsMessage.getCPtr(src)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsMessage_clear(swigCPtr);
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsMessage_empty(swigCPtr);
    return ret;
  }

  public byte getBusId() {
    byte ret = xsensdeviceapiPINVOKE.XsMessage_getBusId(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char getDataBuffer(uint offset) {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessage_getDataBuffer__SWIG_0(swigCPtr, offset);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char getDataBuffer() {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessage_getDataBuffer__SWIG_1(swigCPtr);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public byte getDataByte(uint offset) {
    byte ret = xsensdeviceapiPINVOKE.XsMessage_getDataByte__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public byte getDataByte() {
    byte ret = xsensdeviceapiPINVOKE.XsMessage_getDataByte__SWIG_1(swigCPtr);
    return ret;
  }

  public double getDataDouble(uint offset) {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataDouble__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public double getDataDouble() {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataDouble__SWIG_1(swigCPtr);
    return ret;
  }

  public float getDataFloat(uint offset) {
    float ret = xsensdeviceapiPINVOKE.XsMessage_getDataFloat__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public float getDataFloat() {
    float ret = xsensdeviceapiPINVOKE.XsMessage_getDataFloat__SWIG_1(swigCPtr);
    return ret;
  }

  public double getDataF1220(uint offset) {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataF1220__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public double getDataF1220() {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataF1220__SWIG_1(swigCPtr);
    return ret;
  }

  public double getDataFP1632(uint offset) {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataFP1632__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public double getDataFP1632() {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataFP1632__SWIG_1(swigCPtr);
    return ret;
  }

  public uint getDataLong(uint offset) {
    uint ret = xsensdeviceapiPINVOKE.XsMessage_getDataLong__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public uint getDataLong() {
    uint ret = xsensdeviceapiPINVOKE.XsMessage_getDataLong__SWIG_1(swigCPtr);
    return ret;
  }

  public ulong getDataLongLong(uint offset) {
    ulong ret = xsensdeviceapiPINVOKE.XsMessage_getDataLongLong__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public ulong getDataLongLong() {
    ulong ret = xsensdeviceapiPINVOKE.XsMessage_getDataLongLong__SWIG_1(swigCPtr);
    return ret;
  }

  public ushort getDataShort(uint offset) {
    ushort ret = xsensdeviceapiPINVOKE.XsMessage_getDataShort__SWIG_0(swigCPtr, offset);
    return ret;
  }

  public ushort getDataShort() {
    ushort ret = xsensdeviceapiPINVOKE.XsMessage_getDataShort__SWIG_1(swigCPtr);
    return ret;
  }

  public uint getDataSize() {
    uint ret = xsensdeviceapiPINVOKE.XsMessage_getDataSize(swigCPtr);
    return ret;
  }

  public XsXbusMessageId getMessageId() {
    XsXbusMessageId ret = (XsXbusMessageId)xsensdeviceapiPINVOKE.XsMessage_getMessageId(swigCPtr);
    return ret;
  }

  public XsResultValue toResultValue() {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsMessage_toResultValue(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_unsigned_char getMessageStart() {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessage_getMessageStart(swigCPtr);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public uint getTotalMessageSize() {
    uint ret = xsensdeviceapiPINVOKE.XsMessage_getTotalMessageSize(swigCPtr);
    return ret;
  }

  public bool isChecksumOk() {
    bool ret = xsensdeviceapiPINVOKE.XsMessage_isChecksumOk(swigCPtr);
    return ret;
  }

  public bool loadFromString(SWIGTYPE_p_unsigned_char src, uint msgSize) {
    bool ret = xsensdeviceapiPINVOKE.XsMessage_loadFromString(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(src), msgSize);
    return ret;
  }

  public void recomputeChecksum() {
    xsensdeviceapiPINVOKE.XsMessage_recomputeChecksum(swigCPtr);
  }

  public void resizeData(uint newSize) {
    xsensdeviceapiPINVOKE.XsMessage_resizeData(swigCPtr, newSize);
  }

  public void setBusId(byte busId) {
    xsensdeviceapiPINVOKE.XsMessage_setBusId__SWIG_0(swigCPtr, busId);
  }

  public void setBusId(int busId) {
    xsensdeviceapiPINVOKE.XsMessage_setBusId__SWIG_1(swigCPtr, busId);
  }

  public void setDataBuffer(SWIGTYPE_p_unsigned_char buffer, uint size, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataBuffer__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(buffer), size, offset);
  }

  public void setDataBuffer(SWIGTYPE_p_unsigned_char buffer, uint size) {
    xsensdeviceapiPINVOKE.XsMessage_setDataBuffer__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(buffer), size);
  }

  public void setDataByte(byte value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataByte__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataByte(byte value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataByte__SWIG_1(swigCPtr, value);
  }

  public void setDataDouble(double value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataDouble__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataDouble(double value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataDouble__SWIG_1(swigCPtr, value);
  }

  public void setDataFloat(float value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFloat__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataFloat(float value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFloat__SWIG_1(swigCPtr, value);
  }

  public void setDataF1220(double value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataF1220__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataF1220(double value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataF1220__SWIG_1(swigCPtr, value);
  }

  public void setDataFP1632(double value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFP1632__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataFP1632(double value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFP1632__SWIG_1(swigCPtr, value);
  }

  public void setDataLong(uint value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataLong__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataLong(uint value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataLong__SWIG_1(swigCPtr, value);
  }

  public void setDataLongLong(ulong value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataLongLong__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataLongLong(ulong value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataLongLong__SWIG_1(swigCPtr, value);
  }

  public void setDataShort(ushort value, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataShort__SWIG_0(swigCPtr, value, offset);
  }

  public void setDataShort(ushort value) {
    xsensdeviceapiPINVOKE.XsMessage_setDataShort__SWIG_1(swigCPtr, value);
  }

  public void setMessageId(XsXbusMessageId msgId) {
    xsensdeviceapiPINVOKE.XsMessage_setMessageId(swigCPtr, (int)msgId);
  }

  public void deleteData(uint count, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_deleteData__SWIG_0(swigCPtr, count, offset);
  }

  public void deleteData(uint count) {
    xsensdeviceapiPINVOKE.XsMessage_deleteData__SWIG_1(swigCPtr, count);
  }

  public void insertData(uint count, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_insertData__SWIG_0(swigCPtr, count, offset);
  }

  public void insertData(uint count) {
    xsensdeviceapiPINVOKE.XsMessage_insertData__SWIG_1(swigCPtr, count);
  }

  public static byte getFPValueSize(XsDataIdentifier id) {
    byte ret = xsensdeviceapiPINVOKE.XsMessage_getFPValueSize((int)id);
    return ret;
  }

  public void getDataFPValue(XsDataIdentifier dataIdentifier, SWIGTYPE_p_double dest, uint offset, uint numValues) {
    xsensdeviceapiPINVOKE.XsMessage_getDataFPValue__SWIG_0(swigCPtr, (int)dataIdentifier, SWIGTYPE_p_double.getCPtr(dest), offset, numValues);
  }

  public void getDataFPValue(XsDataIdentifier dataIdentifier, SWIGTYPE_p_double dest, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_getDataFPValue__SWIG_1(swigCPtr, (int)dataIdentifier, SWIGTYPE_p_double.getCPtr(dest), offset);
  }

  public void getDataFPValue(XsDataIdentifier dataIdentifier, SWIGTYPE_p_double dest) {
    xsensdeviceapiPINVOKE.XsMessage_getDataFPValue__SWIG_2(swigCPtr, (int)dataIdentifier, SWIGTYPE_p_double.getCPtr(dest));
  }

  public double getDataFPValue(XsDataIdentifier dataIdentifier, uint offset) {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataFPValue__SWIG_3(swigCPtr, (int)dataIdentifier, offset);
    return ret;
  }

  public double getDataFPValue(XsDataIdentifier dataIdentifier) {
    double ret = xsensdeviceapiPINVOKE.XsMessage_getDataFPValue__SWIG_4(swigCPtr, (int)dataIdentifier);
    return ret;
  }

  public void setDataFPValue(XsDataIdentifier dataIdentifier, SWIGTYPE_p_double data, uint offset, uint numValues) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFPValue__SWIG_0(swigCPtr, (int)dataIdentifier, SWIGTYPE_p_double.getCPtr(data), offset, numValues);
  }

  public void setDataFPValue(XsDataIdentifier dataIdentifier, SWIGTYPE_p_double data, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFPValue__SWIG_1(swigCPtr, (int)dataIdentifier, SWIGTYPE_p_double.getCPtr(data), offset);
  }

  public void setDataFPValue(XsDataIdentifier dataIdentifier, SWIGTYPE_p_double data) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFPValue__SWIG_2(swigCPtr, (int)dataIdentifier, SWIGTYPE_p_double.getCPtr(data));
  }

  public void setDataFPValue(XsDataIdentifier dataIdentifier, double data, uint offset) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFPValue__SWIG_3(swigCPtr, (int)dataIdentifier, data, offset);
  }

  public void setDataFPValue(XsDataIdentifier dataIdentifier, double data) {
    xsensdeviceapiPINVOKE.XsMessage_setDataFPValue__SWIG_4(swigCPtr, (int)dataIdentifier, data);
  }

  public XsByteArray rawMessage() {
    XsByteArray ret = new XsByteArray(xsensdeviceapiPINVOKE.XsMessage_rawMessage(swigCPtr), false);
    return ret;
  }

  public XsString toHexString(uint maxBytes) {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsMessage_toHexString__SWIG_0(swigCPtr, maxBytes), true);
    return ret;
  }

  public XsString toHexString() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsMessage_toHexString__SWIG_1(swigCPtr), true);
    return ret;
  }

}

}