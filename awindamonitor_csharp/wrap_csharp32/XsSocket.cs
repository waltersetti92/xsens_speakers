
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

public class XsSocket : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsSocket(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsSocket obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsSocket() {
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
          xsensdeviceapiPINVOKE.delete_XsSocket(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsSocket(IpProtocol protocol, NetworkLayerProtocol ipVersion) : this(xsensdeviceapiPINVOKE.new_XsSocket__SWIG_0((int)protocol, (int)ipVersion), true) {
  }

  public XsSocket(IpProtocol protocol) : this(xsensdeviceapiPINVOKE.new_XsSocket__SWIG_1((int)protocol), true) {
  }

  public XsSocket(int sockfd, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsSocket__SWIG_2(sockfd, (int)flags), true) {
  }

  public XsSocket(int sockfd) : this(xsensdeviceapiPINVOKE.new_XsSocket__SWIG_3(sockfd), true) {
  }

  public XsResultValue close() {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_close(swigCPtr);
    return ret;
  }

  public ulong nativeDescriptor() {
    ulong ret = xsensdeviceapiPINVOKE.XsSocket_nativeDescriptor(swigCPtr);
    return ret;
  }

  public int read(XsByteArray buffer, int timeout) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_read__SWIG_0(swigCPtr, XsByteArray.getCPtr(buffer), timeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int read(XsByteArray buffer) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_read__SWIG_1(swigCPtr, XsByteArray.getCPtr(buffer));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int read(SWIGTYPE_p_void dest, uint size, int timeout) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_read__SWIG_2(swigCPtr, SWIGTYPE_p_void.getCPtr(dest), size, timeout);
    return ret;
  }

  public int read(SWIGTYPE_p_void dest, uint size) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_read__SWIG_3(swigCPtr, SWIGTYPE_p_void.getCPtr(dest), size);
    return ret;
  }

  public int readFrom(XsByteArray buffer, XsString hostname, SWIGTYPE_p_unsigned_short port, int timeout) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_0(swigCPtr, XsByteArray.getCPtr(buffer), XsString.getCPtr(hostname), SWIGTYPE_p_unsigned_short.getCPtr(port), timeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int readFrom(XsByteArray buffer, XsString hostname, SWIGTYPE_p_unsigned_short port) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_1(swigCPtr, XsByteArray.getCPtr(buffer), XsString.getCPtr(hostname), SWIGTYPE_p_unsigned_short.getCPtr(port));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int readFrom(XsByteArray buffer, XsString hostname) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_2(swigCPtr, XsByteArray.getCPtr(buffer), XsString.getCPtr(hostname));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int readFrom(XsByteArray buffer) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_3(swigCPtr, XsByteArray.getCPtr(buffer));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int readFrom(SWIGTYPE_p_void dest, uint size, XsString hostname, SWIGTYPE_p_unsigned_short port, int timeout) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_4(swigCPtr, SWIGTYPE_p_void.getCPtr(dest), size, XsString.getCPtr(hostname), SWIGTYPE_p_unsigned_short.getCPtr(port), timeout);
    return ret;
  }

  public int readFrom(SWIGTYPE_p_void dest, uint size, XsString hostname, SWIGTYPE_p_unsigned_short port) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_5(swigCPtr, SWIGTYPE_p_void.getCPtr(dest), size, XsString.getCPtr(hostname), SWIGTYPE_p_unsigned_short.getCPtr(port));
    return ret;
  }

  public int readFrom(SWIGTYPE_p_void dest, uint size, XsString hostname) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_6(swigCPtr, SWIGTYPE_p_void.getCPtr(dest), size, XsString.getCPtr(hostname));
    return ret;
  }

  public int readFrom(SWIGTYPE_p_void dest, uint size) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_readFrom__SWIG_7(swigCPtr, SWIGTYPE_p_void.getCPtr(dest), size);
    return ret;
  }

  public int write(XsByteArray buffer) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_write__SWIG_0(swigCPtr, XsByteArray.getCPtr(buffer));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int write(SWIGTYPE_p_void data, uint size) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_write__SWIG_1(swigCPtr, SWIGTYPE_p_void.getCPtr(data), size);
    return ret;
  }

  public int writeTo(XsByteArray buffer, XsString hostname, ushort port) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_writeTo__SWIG_0(swigCPtr, XsByteArray.getCPtr(buffer), XsString.getCPtr(hostname), port);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int writeTo(SWIGTYPE_p_void data, uint size, XsString hostname, ushort port) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_writeTo__SWIG_1(swigCPtr, SWIGTYPE_p_void.getCPtr(data), size, XsString.getCPtr(hostname), port);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void flush() {
    xsensdeviceapiPINVOKE.XsSocket_flush(swigCPtr);
  }

  public int select(int mstimeout, SWIGTYPE_p_int canRead, SWIGTYPE_p_int canWrite) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_select(swigCPtr, mstimeout, SWIGTYPE_p_int.getCPtr(canRead), SWIGTYPE_p_int.getCPtr(canWrite));
    return ret;
  }

  public XsSocket accept(int mstimeout) {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsSocket_accept__SWIG_0(swigCPtr, mstimeout);
    XsSocket ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsSocket(cPtr, false);
    return ret;
  }

  public XsSocket accept() {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsSocket_accept__SWIG_1(swigCPtr);
    XsSocket ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsSocket(cPtr, false);
    return ret;
  }

  public XsResultValue setSocketOption(XsSocketOption option, SWIGTYPE_p_void valuePtr, int valueSize) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_setSocketOption__SWIG_0(swigCPtr, (int)option, SWIGTYPE_p_void.getCPtr(valuePtr), valueSize);
    return ret;
  }

  public XsResultValue setSocketOption(XsSocketOption option, int value) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_setSocketOption__SWIG_1(swigCPtr, (int)option, value);
    return ret;
  }

  public XsResultValue bind(ushort port) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_bind__SWIG_0(swigCPtr, port);
    return ret;
  }

  public XsResultValue bind(XsString hostname, ushort port) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_bind__SWIG_1(swigCPtr, XsString.getCPtr(hostname), port);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsResultValue listen(int maxPending) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_listen__SWIG_0(swigCPtr, maxPending);
    return ret;
  }

  public XsResultValue listen() {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_listen__SWIG_1(swigCPtr);
    return ret;
  }

  public XsResultValue connect(XsString host, ushort port) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsSocket_connect(swigCPtr, XsString.getCPtr(host), port);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isUsable() {
    bool ret = xsensdeviceapiPINVOKE.XsSocket_isUsable(swigCPtr);
    return ret;
  }

  public XsString getRemoteAddress() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsSocket_getRemoteAddress(swigCPtr), true);
    return ret;
  }

  public int getLastSystemError() {
    int ret = xsensdeviceapiPINVOKE.XsSocket_getLastSystemError(swigCPtr);
    return ret;
  }

  public int broadcast(SWIGTYPE_p_void data, uint size, ushort port) {
    int ret = xsensdeviceapiPINVOKE.XsSocket_broadcast(swigCPtr, SWIGTYPE_p_void.getCPtr(data), size, port);
    return ret;
  }

  public bool enableBroadcasts(bool enable) {
    bool ret = xsensdeviceapiPINVOKE.XsSocket_enableBroadcasts(swigCPtr, enable);
    return ret;
  }

}

}
