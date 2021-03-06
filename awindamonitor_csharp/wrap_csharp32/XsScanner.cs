
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

public class XsScanner : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsScanner(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsScanner obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsScanner() {
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
          xsensdeviceapiPINVOKE.delete_XsScanner(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static XsPortInfoArray scanPorts(XsBaudRate baudrate, int singleScanTimeout, bool ignoreNonXsensDevices, bool detectRs485) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanPorts__SWIG_0((int)baudrate, singleScanTimeout, ignoreNonXsensDevices, detectRs485), true);
    return ret;
  }

  public static XsPortInfoArray scanPorts(XsBaudRate baudrate, int singleScanTimeout, bool ignoreNonXsensDevices) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanPorts__SWIG_1((int)baudrate, singleScanTimeout, ignoreNonXsensDevices), true);
    return ret;
  }

  public static XsPortInfoArray scanPorts(XsBaudRate baudrate, int singleScanTimeout) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanPorts__SWIG_2((int)baudrate, singleScanTimeout), true);
    return ret;
  }

  public static XsPortInfoArray scanPorts(XsBaudRate baudrate) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanPorts__SWIG_3((int)baudrate), true);
    return ret;
  }

  public static XsPortInfoArray scanPorts() {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanPorts__SWIG_4(), true);
    return ret;
  }

  public static bool scanPort(XsPortInfo port, XsBaudRate baudrate, int singleScanTimeout, bool detectRs485) {
    bool ret = xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_0(XsPortInfo.getCPtr(port), (int)baudrate, singleScanTimeout, detectRs485);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool scanPort(XsPortInfo port, XsBaudRate baudrate, int singleScanTimeout) {
    bool ret = xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_1(XsPortInfo.getCPtr(port), (int)baudrate, singleScanTimeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool scanPort(XsPortInfo port, XsBaudRate baudrate) {
    bool ret = xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_2(XsPortInfo.getCPtr(port), (int)baudrate);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool scanPort(XsPortInfo port) {
    bool ret = xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_3(XsPortInfo.getCPtr(port));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfo scanPort(XsString portName, XsBaudRate baudrate, int singleScanTimeout, bool detectRs485) {
    XsPortInfo ret = new XsPortInfo(xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_4(XsString.getCPtr(portName), (int)baudrate, singleScanTimeout, detectRs485), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfo scanPort(XsString portName, XsBaudRate baudrate, int singleScanTimeout) {
    XsPortInfo ret = new XsPortInfo(xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_5(XsString.getCPtr(portName), (int)baudrate, singleScanTimeout), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfo scanPort(XsString portName, XsBaudRate baudrate) {
    XsPortInfo ret = new XsPortInfo(xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_6(XsString.getCPtr(portName), (int)baudrate), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfo scanPort(XsString portName) {
    XsPortInfo ret = new XsPortInfo(xsensdeviceapiPINVOKE.XsScanner_scanPort__SWIG_7(XsString.getCPtr(portName)), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray scanComPortList(XsStringArray portList, XsIntArray portLinesOptionsList, XsBaudRate baudrate, int singleScanTimeout) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanComPortList__SWIG_0(XsStringArray.getCPtr(portList), XsIntArray.getCPtr(portLinesOptionsList), (int)baudrate, singleScanTimeout), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray scanComPortList(XsStringArray portList, XsIntArray portLinesOptionsList, XsBaudRate baudrate) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanComPortList__SWIG_1(XsStringArray.getCPtr(portList), XsIntArray.getCPtr(portLinesOptionsList), (int)baudrate), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray scanComPortList(XsStringArray portList, XsIntArray portLinesOptionsList) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanComPortList__SWIG_2(XsStringArray.getCPtr(portList), XsIntArray.getCPtr(portLinesOptionsList)), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray scanComPortList(XsStringArray portList) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_scanComPortList__SWIG_3(XsStringArray.getCPtr(portList)), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray enumerateSerialPorts(bool ignoreNonXsensDevices) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_enumerateSerialPorts__SWIG_0(ignoreNonXsensDevices), true);
    return ret;
  }

  public static XsPortInfoArray enumerateSerialPorts() {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_enumerateSerialPorts__SWIG_1(), true);
    return ret;
  }

  public static XsPortInfoArray filterResponsiveDevices(XsPortInfoArray ports, XsBaudRate baudrate, int singleScanTimeout, bool detectRs485) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_filterResponsiveDevices__SWIG_0(XsPortInfoArray.getCPtr(ports), (int)baudrate, singleScanTimeout, detectRs485), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray filterResponsiveDevices(XsPortInfoArray ports, XsBaudRate baudrate, int singleScanTimeout) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_filterResponsiveDevices__SWIG_1(XsPortInfoArray.getCPtr(ports), (int)baudrate, singleScanTimeout), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray filterResponsiveDevices(XsPortInfoArray ports, XsBaudRate baudrate) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_filterResponsiveDevices__SWIG_2(XsPortInfoArray.getCPtr(ports), (int)baudrate), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray filterResponsiveDevices(XsPortInfoArray ports) {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_filterResponsiveDevices__SWIG_3(XsPortInfoArray.getCPtr(ports)), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray enumerateUsbDevices() {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_enumerateUsbDevices(), true);
    return ret;
  }

  public static XsUsbHubInfo scanUsbHub(XsPortInfo port) {
    XsUsbHubInfo ret = new XsUsbHubInfo(xsensdeviceapiPINVOKE.XsScanner_scanUsbHub(XsPortInfo.getCPtr(port)), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static XsPortInfoArray enumerateNetworkDevices() {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_enumerateNetworkDevices(), true);
    return ret;
  }

  public static XsPortInfoArray enumerateBluetoothDevices() {
    XsPortInfoArray ret = new XsPortInfoArray(xsensdeviceapiPINVOKE.XsScanner_enumerateBluetoothDevices(), true);
    return ret;
  }

  public static void abortScan() {
    xsensdeviceapiPINVOKE.XsScanner_abortScan();
  }

  public static void setScanLogCallback(SWIGTYPE_p_f_p_q_const__XsString__void cb) {
    xsensdeviceapiPINVOKE.XsScanner_setScanLogCallback(SWIGTYPE_p_f_p_q_const__XsString__void.getCPtr(cb));
  }

  public XsScanner() : this(xsensdeviceapiPINVOKE.new_XsScanner(), true) {
  }

}

}
