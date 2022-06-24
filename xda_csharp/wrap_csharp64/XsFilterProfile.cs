
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

public class XsFilterProfile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsFilterProfile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsFilterProfile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsFilterProfile() {
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
          xsensdeviceapiPINVOKE.delete_XsFilterProfile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsFilterProfile(byte type_, byte version_, string kind_, string label_, char filterType_, byte filterMajor_, byte filterMinor_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_0(type_, version_, kind_, label_, filterType_, filterMajor_, filterMinor_), true) {
  }

  public XsFilterProfile(byte type_, byte version_, string kind_, string label_, char filterType_, byte filterMajor_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_1(type_, version_, kind_, label_, filterType_, filterMajor_), true) {
  }

  public XsFilterProfile(byte type_, byte version_, string kind_, string label_, char filterType_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_2(type_, version_, kind_, label_, filterType_), true) {
  }

  public XsFilterProfile(byte type_, byte version_, string kind_, string label_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_3(type_, version_, kind_, label_), true) {
  }

  public XsFilterProfile(byte type_, byte version_, string kind_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_4(type_, version_, kind_), true) {
  }

  public XsFilterProfile(byte type_, byte version_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_5(type_, version_), true) {
  }

  public XsFilterProfile(byte type_) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_6(type_), true) {
  }

  public XsFilterProfile() : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_7(), true) {
  }

  public XsFilterProfile(XsFilterProfile other) : this(xsensdeviceapiPINVOKE.new_XsFilterProfile__SWIG_8(XsFilterProfile.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsFilterProfile_empty(swigCPtr);
    return ret;
  }

  public XsString toXsString() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsFilterProfile_toXsString(swigCPtr), true);
    return ret;
  }

  public byte type() {
    byte ret = xsensdeviceapiPINVOKE.XsFilterProfile_type(swigCPtr);
    return ret;
  }

  public byte version() {
    byte ret = xsensdeviceapiPINVOKE.XsFilterProfile_version(swigCPtr);
    return ret;
  }

  public string label() {
    string ret = xsensdeviceapiPINVOKE.XsFilterProfile_label(swigCPtr);
    return ret;
  }

  public string kind() {
    string ret = xsensdeviceapiPINVOKE.XsFilterProfile_kind(swigCPtr);
    return ret;
  }

  public char filterType() {
    char ret = xsensdeviceapiPINVOKE.XsFilterProfile_filterType(swigCPtr);
    return ret;
  }

  public byte filterMajor() {
    byte ret = xsensdeviceapiPINVOKE.XsFilterProfile_filterMajor(swigCPtr);
    return ret;
  }

  public byte filterMinor() {
    byte ret = xsensdeviceapiPINVOKE.XsFilterProfile_filterMinor(swigCPtr);
    return ret;
  }

  public void setType(byte type_) {
    xsensdeviceapiPINVOKE.XsFilterProfile_setType(swigCPtr, type_);
  }

  public void setVersion(byte version_) {
    xsensdeviceapiPINVOKE.XsFilterProfile_setVersion(swigCPtr, version_);
  }

  public void setLabel(string label_) {
    xsensdeviceapiPINVOKE.XsFilterProfile_setLabel(swigCPtr, label_);
  }

  public void setKind(string kind_) {
    xsensdeviceapiPINVOKE.XsFilterProfile_setKind(swigCPtr, kind_);
  }

  public void setFilterType(char filterType_) {
    xsensdeviceapiPINVOKE.XsFilterProfile_setFilterType(swigCPtr, filterType_);
  }

  public void setFilterVersion(byte major_, byte minor_) {
    xsensdeviceapiPINVOKE.XsFilterProfile_setFilterVersion(swigCPtr, major_, minor_);
  }

  public void swap(XsFilterProfile other) {
    xsensdeviceapiPINVOKE.XsFilterProfile_swap(swigCPtr, XsFilterProfile.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
