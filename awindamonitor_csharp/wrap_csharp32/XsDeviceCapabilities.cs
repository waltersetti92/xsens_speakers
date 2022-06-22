
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

public class XsDeviceCapabilities : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceCapabilities(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDeviceCapabilities obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceCapabilities() {
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
          xsensdeviceapiPINVOKE.delete_XsDeviceCapabilities(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsDeviceCapabilities(uint flags) : this(xsensdeviceapiPINVOKE.new_XsDeviceCapabilities__SWIG_0(flags), true) {
  }

  public XsDeviceCapabilities() : this(xsensdeviceapiPINVOKE.new_XsDeviceCapabilities__SWIG_1(), true) {
  }

  public XsDeviceCapabilities(XsDeviceCapabilities other) : this(xsensdeviceapiPINVOKE.new_XsDeviceCapabilities__SWIG_2(XsDeviceCapabilities.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasAccelerometer() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_hasAccelerometer(swigCPtr);
    return ret;
  }

  public bool hasGyroscope() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_hasGyroscope(swigCPtr);
    return ret;
  }

  public bool hasMagnetometer() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_hasMagnetometer(swigCPtr);
    return ret;
  }

  public bool hasBarometer() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_hasBarometer(swigCPtr);
    return ret;
  }

  public bool hasGnss() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_hasGnss(swigCPtr);
    return ret;
  }

  public bool isImu() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_isImu(swigCPtr);
    return ret;
  }

  public bool isVru() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_isVru(swigCPtr);
    return ret;
  }

  public bool isAhrs() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_isAhrs(swigCPtr);
    return ret;
  }

  public bool isGnssIns() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_isGnssIns(swigCPtr);
    return ret;
  }

  public bool isRtk() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceCapabilities_isRtk(swigCPtr);
    return ret;
  }

}

}
