using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/ThrowableWrapper", DoNotGenerateAcw=true)]
	public partial class ThrowableWrapper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/ThrowableWrapper", typeof (ThrowableWrapper));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ThrowableWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/constructor[@name='ThrowableWrapper' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.arthenica.smartexception.ThrowableWrapper[]'] and parameter[5][@type='com.arthenica.smartexception.StackTraceElementWrapper[]']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;[Lcom/arthenica/smartexception/ThrowableWrapper;[Lcom/arthenica/smartexception/StackTraceElementWrapper;)V", "")]
		public unsafe ThrowableWrapper (string? message, global::Com.Arthenica.Smartexception.ThrowableWrapper? cause, string? className, global::Com.Arthenica.Smartexception.ThrowableWrapper[]? suppressed, global::Com.Arthenica.Smartexception.StackTraceElementWrapper[]? stackTrace) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;[Lcom/arthenica/smartexception/ThrowableWrapper;[Lcom/arthenica/smartexception/StackTraceElementWrapper;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString ((string?)message);
			IntPtr native_className = JNIEnv.NewString ((string?)className);
			IntPtr native_suppressed = JNIEnv.NewArray (suppressed);
			IntPtr native_stackTrace = JNIEnv.NewArray (stackTrace);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cause).Handle);
				__args [2] = new JniArgumentValue (native_className);
				__args [3] = new JniArgumentValue (native_suppressed);
				__args [4] = new JniArgumentValue (native_stackTrace);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_className);
				if (suppressed != null) {
					JNIEnv.CopyArray (native_suppressed, suppressed);
					JNIEnv.DeleteLocalRef (native_suppressed);
				}
				if (stackTrace != null) {
					JNIEnv.CopyArray (native_stackTrace, stackTrace);
					JNIEnv.DeleteLocalRef (native_stackTrace);
				}
				global::System.GC.KeepAlive (cause);
				global::System.GC.KeepAlive (suppressed);
				global::System.GC.KeepAlive (stackTrace);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/constructor[@name='ThrowableWrapper' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe ThrowableWrapper (global::Java.Lang.Throwable? throwable) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/constructor[@name='ThrowableWrapper' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Set&lt;java.lang.Throwable&gt;']]"
		[Register (".ctor", "(Ljava/lang/Throwable;Ljava/util/Set;)V", "")]
		public unsafe ThrowableWrapper (global::Java.Lang.Throwable? throwable, global::System.Collections.Generic.ICollection<global::Java.Lang.Throwable>? alreadyWrapped) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;Ljava/util/Set;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_alreadyWrapped = global::Android.Runtime.JavaSet<global::Java.Lang.Throwable>.ToLocalJniHandle (alreadyWrapped);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_alreadyWrapped);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alreadyWrapped);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (alreadyWrapped);
			}
		}

		static Delegate? cb_getCause;
#pragma warning disable 0169
		static Delegate GetGetCauseHandler ()
		{
			if (cb_getCause == null)
				cb_getCause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCause);
			return cb_getCause;
		}

		static IntPtr n_GetCause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.ThrowableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Cause);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Smartexception.ThrowableWrapper? Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Lcom/arthenica/smartexception/ThrowableWrapper;", "GetGetCauseHandler")]
			get {
				const string __id = "getCause.()Lcom/arthenica/smartexception/ThrowableWrapper;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.ThrowableWrapper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getClassName;
#pragma warning disable 0169
		static Delegate GetGetClassNameHandler ()
		{
			if (cb_getClassName == null)
				cb_getClassName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClassName);
			return cb_getClassName;
		}

		static IntPtr n_GetClassName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.ThrowableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		public virtual unsafe string? ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get {
				const string __id = "getClassName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.ThrowableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string? Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getStackTrace;
#pragma warning disable 0169
		static Delegate GetGetStackTraceHandler ()
		{
			if (cb_getStackTrace == null)
				cb_getStackTrace = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStackTrace);
			return cb_getStackTrace;
		}

		static IntPtr n_GetStackTrace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.ThrowableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetStackTrace ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/method[@name='getStackTrace' and count(parameter)=0]"
		[Register ("getStackTrace", "()[Lcom/arthenica/smartexception/StackTraceElementWrapper;", "GetGetStackTraceHandler")]
		public virtual unsafe global::Com.Arthenica.Smartexception.StackTraceElementWrapper[]? GetStackTrace ()
		{
			const string __id = "getStackTrace.()[Lcom/arthenica/smartexception/StackTraceElementWrapper;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Arthenica.Smartexception.StackTraceElementWrapper[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Arthenica.Smartexception.StackTraceElementWrapper));
			} finally {
			}
		}

		static Delegate? cb_getSuppressed;
#pragma warning disable 0169
		static Delegate GetGetSuppressedHandler ()
		{
			if (cb_getSuppressed == null)
				cb_getSuppressed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSuppressed);
			return cb_getSuppressed;
		}

		static IntPtr n_GetSuppressed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.ThrowableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetSuppressed ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='ThrowableWrapper']/method[@name='getSuppressed' and count(parameter)=0]"
		[Register ("getSuppressed", "()[Lcom/arthenica/smartexception/ThrowableWrapper;", "GetGetSuppressedHandler")]
		public virtual unsafe global::Com.Arthenica.Smartexception.ThrowableWrapper[]? GetSuppressed ()
		{
			const string __id = "getSuppressed.()[Lcom/arthenica/smartexception/ThrowableWrapper;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Arthenica.Smartexception.ThrowableWrapper[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Arthenica.Smartexception.ThrowableWrapper));
			} finally {
			}
		}

	}
}
