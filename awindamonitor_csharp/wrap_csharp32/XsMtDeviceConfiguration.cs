
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

public class XsMtDeviceConfiguration : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsMtDeviceConfiguration(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsMtDeviceConfiguration obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsMtDeviceConfiguration() {
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
          xsensdeviceapiPINVOKE.delete_XsMtDeviceConfiguration(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ulong m_deviceId {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_deviceId_set(swigCPtr, value);
    } 
    get {
      ulong ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_deviceId_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char m_reserved {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_reserved_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_reserved_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public ushort m_filterProfile {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterProfile_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterProfile_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_fwRevMajor {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_fwRevMajor_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_fwRevMajor_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_fwRevMinor {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_fwRevMinor_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_fwRevMinor_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_fwRevRevision {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_fwRevRevision_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_fwRevRevision_get(swigCPtr);
      return ret;
    } 
  }

  public char m_filterType {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterType_set(swigCPtr, value);
    } 
    get {
      char ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterType_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_filterMajor {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterMajor_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterMajor_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_filterMinor {
    set {
      xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterMinor_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMtDeviceConfiguration_m_filterMinor_get(swigCPtr);
      return ret;
    } 
  }

  public XsMtDeviceConfiguration() : this(xsensdeviceapiPINVOKE.new_XsMtDeviceConfiguration(), true) {
  }

}

}
