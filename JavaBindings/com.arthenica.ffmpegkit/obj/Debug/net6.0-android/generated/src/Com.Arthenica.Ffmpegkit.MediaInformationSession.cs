using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/MediaInformationSession", DoNotGenerateAcw=true)]
	public partial class MediaInformationSession : global::Com.Arthenica.Ffmpegkit.AbstractSession, global::Com.Arthenica.Ffmpegkit.ISession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/MediaInformationSession", typeof (MediaInformationSession));

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

		protected MediaInformationSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/constructor[@name='MediaInformationSession' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		public unsafe MediaInformationSession (string[]? arguments) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/constructor[@name='MediaInformationSession' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;)V", "")]
		public unsafe MediaInformationSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/constructor[@name='MediaInformationSession' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)V", "")]
		public unsafe MediaInformationSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)V";

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CompleteCallback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? CompleteCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/method[@name='getCompleteCallback' and count(parameter)=0]"
			[Register ("getCompleteCallback", "()Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;", "GetGetCompleteCallbackHandler")]
			get {
				const string __id = "getCompleteCallback.()Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFmpeg;
		}
#pragma warning restore 0169

		public override unsafe bool IsFFmpeg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/method[@name='isFFmpeg' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFprobe;
		}
#pragma warning restore 0169

		public override unsafe bool IsFFprobe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/method[@name='isFFprobe' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMediaInformation;
		}
#pragma warning restore 0169

		public override unsafe bool IsMediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/method[@name='isMediaInformation' and count(parameter)=0]"
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

		static Delegate? cb_getMediaInformation;
#pragma warning disable 0169
		static Delegate GetGetMediaInformationHandler ()
		{
			if (cb_getMediaInformation == null)
				cb_getMediaInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMediaInformation);
			return cb_getMediaInformation;
		}

		static IntPtr n_GetMediaInformation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.MediaInformation);
		}
#pragma warning restore 0169

		static Delegate? cb_setMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_;
#pragma warning disable 0169
		static Delegate GetSetMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_Handler ()
		{
			if (cb_setMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_ == null)
				cb_setMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_);
			return cb_setMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_;
		}

		static void n_SetMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaInformation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var mediaInformation = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (native_mediaInformation, JniHandleOwnership.DoNotTransfer);
			__this.MediaInformation = mediaInformation;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.MediaInformation? MediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/method[@name='getMediaInformation' and count(parameter)=0]"
			[Register ("getMediaInformation", "()Lcom/arthenica/ffmpegkit/MediaInformation;", "GetGetMediaInformationHandler")]
			get {
				const string __id = "getMediaInformation.()Lcom/arthenica/ffmpegkit/MediaInformation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationSession']/method[@name='setMediaInformation' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformation']]"
			[Register ("setMediaInformation", "(Lcom/arthenica/ffmpegkit/MediaInformation;)V", "GetSetMediaInformation_Lcom_arthenica_ffmpegkit_MediaInformation_Handler")]
			set {
				const string __id = "setMediaInformation.(Lcom/arthenica/ffmpegkit/MediaInformation;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
