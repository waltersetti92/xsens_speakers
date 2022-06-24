
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

public class XsSnapshot : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsSnapshot(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsSnapshot obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsSnapshot() {
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
          xsensdeviceapiPINVOKE.delete_XsSnapshot(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsDeviceId m_deviceId {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_deviceId_set(swigCPtr, XsDeviceId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsSnapshot_m_deviceId_get(swigCPtr);
      XsDeviceId ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsDeviceId(cPtr, false);
      return ret;
    } 
  }

  public uint m_frameNumber {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_frameNumber_set(swigCPtr, value);
    } 
    get {
      uint ret = xsensdeviceapiPINVOKE.XsSnapshot_m_frameNumber_get(swigCPtr);
      return ret;
    } 
  }

  public ulong m_timestamp {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_timestamp_set(swigCPtr, value);
    } 
    get {
      ulong ret = xsensdeviceapiPINVOKE.XsSnapshot_m_timestamp_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_iQ {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_iQ_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsSnapshot_m_iQ_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_long_long m_iV {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_iV_set(swigCPtr, SWIGTYPE_p_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsSnapshot_m_iV_get(swigCPtr);
      SWIGTYPE_p_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_long_long(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_int m_mag {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_mag_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsSnapshot_m_mag_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public int m_baro {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_baro_set(swigCPtr, value);
    } 
    get {
      int ret = xsensdeviceapiPINVOKE.XsSnapshot_m_baro_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_status {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_status_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsSnapshot_m_status_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_accClippingCounter {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_accClippingCounter_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsSnapshot_m_accClippingCounter_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_gyrClippingCounter {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_gyrClippingCounter_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsSnapshot_m_gyrClippingCounter_get(swigCPtr);
      return ret;
    } 
  }

  public SnapshotType m_type {
    set {
      xsensdeviceapiPINVOKE.XsSnapshot_m_type_set(swigCPtr, (int)value);
    } 
    get {
      SnapshotType ret = (SnapshotType)xsensdeviceapiPINVOKE.XsSnapshot_m_type_get(swigCPtr);
      return ret;
    } 
  }

  public XsSnapshot() : this(xsensdeviceapiPINVOKE.new_XsSnapshot(), true) {
  }

}

}
