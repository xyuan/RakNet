/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class RakNetSocket : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetSocket(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetSocket obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetSocket() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakNetSocket(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public RakNetSocket() : this(RakNetPINVOKE.new_RakNetSocket(), true) {
  }

  public uint s {
    set {
      RakNetPINVOKE.RakNetSocket_s_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.RakNetSocket_s_get(swigCPtr);
      return ret;
    } 
  }

  public uint userConnectionSocketIndex {
    set {
      RakNetPINVOKE.RakNetSocket_userConnectionSocketIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.RakNetSocket_userConnectionSocketIndex_get(swigCPtr);
      return ret;
    } 
  }

  public SystemAddress boundAddress {
    set {
      RakNetPINVOKE.RakNetSocket_boundAddress_set(swigCPtr, SystemAddress.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.RakNetSocket_boundAddress_get(swigCPtr);
      SystemAddress ret = (cPtr == IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
      return ret;
    } 
  }

  public ushort remotePortRakNetWasStartedOn_PS3 {
    set {
      RakNetPINVOKE.RakNetSocket_remotePortRakNetWasStartedOn_PS3_set(swigCPtr, value);
    } 
    get {
      ushort ret = RakNetPINVOKE.RakNetSocket_remotePortRakNetWasStartedOn_PS3_get(swigCPtr);
      return ret;
    } 
  }

}

}
