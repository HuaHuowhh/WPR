using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/FFprobeSession", DoNotGenerateAcw=true)]
	public partial class FFprobeSession : global::Com.Arthenica.Ffmpegkit.AbstractSession, global::Com.Arthenica.Ffmpegkit.ISession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/FFprobeSession", typeof (FFprobeSession));

		internal static new IntPtr class_ref {
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

		protected FFprobeSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/constructor[@name='FFprobeSession' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		public unsafe FFprobeSession (string[]? arguments) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arguments);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/constructor[@name='FFprobeSession' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)V", "")]
		public unsafe FFprobeSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/constructor[@name='FFprobeSession' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)V", "")]
		public unsafe FFprobeSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/constructor[@name='FFprobeSession' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.LogRedirectionStrategy']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V", "")]
		public unsafe FFprobeSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? logRedirectionStrategy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((logRedirectionStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logRedirectionStrategy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (logRedirectionStrategy);
			}
		}

		static Delegate? cb_getCompleteCallback;
#pragma warning disable 0169
		static Delegate GetGetCompleteCallbackHandler ()
		{
			if (cb_getCompleteCallback == null)
				cb_getCompleteCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCompleteCallback);
			return cb_getCompleteCallback;
		}

		static IntPtr n_GetCompleteCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CompleteCallback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? CompleteCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/method[@name='getCompleteCallback' and count(parameter)=0]"
			[Register ("getCompleteCallback", "()Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;", "GetGetCompleteCallbackHandler")]
			get {
				const string __id = "getCompleteCallback.()Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isFFmpeg;
#pragma warning disable 0169
		static Delegate GetIsFFmpegHandler ()
		{
			if (cb_isFFmpeg == null)
				cb_isFFmpeg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFFmpeg);
			return cb_isFFmpeg;
		}

		static bool n_IsFFmpeg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFmpeg;
		}
#pragma warning restore 0169

		public override unsafe bool IsFFmpeg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/method[@name='isFFmpeg' and count(parameter)=0]"
			[Register ("isFFmpeg", "()Z", "GetIsFFmpegHandler")]
			get {
				const string __id = "isFFmpeg.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isFFprobe;
#pragma warning disable 0169
		static Delegate GetIsFFprobeHandler ()
		{
			if (cb_isFFprobe == null)
				cb_isFFprobe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFFprobe);
			return cb_isFFprobe;
		}

		static bool n_IsFFprobe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFprobe;
		}
#pragma warning restore 0169

		public override unsafe bool IsFFprobe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/method[@name='isFFprobe' and count(parameter)=0]"
			[Register ("isFFprobe", "()Z", "GetIsFFprobeHandler")]
			get {
				const string __id = "isFFprobe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isMediaInformation;
#pragma warning disable 0169
		static Delegate GetIsMediaInformationHandler ()
		{
			if (cb_isMediaInformation == null)
				cb_isMediaInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMediaInformation);
			return cb_isMediaInformation;
		}

		static bool n_IsMediaInformation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMediaInformation;
		}
#pragma warning restore 0169

		public override unsafe bool IsMediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeSession']/method[@name='isMediaInformation' and count(parameter)=0]"
			[Register ("isMediaInformation", "()Z", "GetIsMediaInformationHandler")]
			get {
				const string __id = "isMediaInformation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
