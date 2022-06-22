
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

public class XsVersion : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsVersion(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsVersion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsVersion() {
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
          xsensdeviceapiPINVOKE.delete_XsVersion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsVersion(int maj, int min, int rev, int build, XsString extra) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_0(maj, min, rev, build, XsString.getCPtr(extra)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVersion(int maj, int min, int rev, int build, int reposVersion, XsString extra) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_1(maj, min, rev, build, reposVersion, XsString.getCPtr(extra)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVersion(int maj, int min, int rev, int build, int reposVersion) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_2(maj, min, rev, build, reposVersion), true) {
  }

  public XsVersion(int maj, int min, int rev, int build) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_3(maj, min, rev, build), true) {
  }

  public XsVersion(int maj, int min, int rev) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_4(maj, min, rev), true) {
  }

  public XsVersion(int maj, int min) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_5(maj, min), true) {
  }

  public XsVersion(int maj) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_6(maj), true) {
  }

  public XsVersion() : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_7(), true) {
  }

  public XsVersion(XsString vString) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_8(XsString.getCPtr(vString)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVersion(XsSimpleVersion simpleVersion) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_9(XsSimpleVersion.getCPtr(simpleVersion)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVersion(XsVersion other) : this(xsensdeviceapiPINVOKE.new_XsVersion__SWIG_10(XsVersion.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isEqual(XsVersion other) {
    bool ret = xsensdeviceapiPINVOKE.XsVersion_isEqual(swigCPtr, XsVersion.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsVersion_empty(swigCPtr);
    return ret;
  }

  public XsString toXsString() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsVersion_toXsString(swigCPtr), true);
    return ret;
  }

  public XsString toSimpleString() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsVersion_toSimpleString(swigCPtr), true);
    return ret;
  }

  public XsSimpleVersion toSimpleVersion() {
    XsSimpleVersion ret = new XsSimpleVersion(xsensdeviceapiPINVOKE.XsVersion_toSimpleVersion(swigCPtr), true);
    return ret;
  }

  public int major() {
    int ret = xsensdeviceapiPINVOKE.XsVersion_major(swigCPtr);
    return ret;
  }

  public int minor() {
    int ret = xsensdeviceapiPINVOKE.XsVersion_minor(swigCPtr);
    return ret;
  }

  public int revision() {
    int ret = xsensdeviceapiPINVOKE.XsVersion_revision(swigCPtr);
    return ret;
  }

  public int build() {
    int ret = xsensdeviceapiPINVOKE.XsVersion_build(swigCPtr);
    return ret;
  }

  public int reposVersion() {
    int ret = xsensdeviceapiPINVOKE.XsVersion_reposVersion(swigCPtr);
    return ret;
  }

  public XsString extra() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsVersion_extra(swigCPtr), false);
    return ret;
  }

  public void setMajor(int major) {
    xsensdeviceapiPINVOKE.XsVersion_setMajor(swigCPtr, major);
  }

  public void setMinor(int minor) {
    xsensdeviceapiPINVOKE.XsVersion_setMinor(swigCPtr, minor);
  }

  public void setRevision(int revision) {
    xsensdeviceapiPINVOKE.XsVersion_setRevision(swigCPtr, revision);
  }

  public void setBuild(int build) {
    xsensdeviceapiPINVOKE.XsVersion_setBuild(swigCPtr, build);
  }

  public void setReposVersion(int reposVersion) {
    xsensdeviceapiPINVOKE.XsVersion_setReposVersion(swigCPtr, reposVersion);
  }

  public void setExtra(XsString extra) {
    xsensdeviceapiPINVOKE.XsVersion_setExtra(swigCPtr, XsString.getCPtr(extra));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}