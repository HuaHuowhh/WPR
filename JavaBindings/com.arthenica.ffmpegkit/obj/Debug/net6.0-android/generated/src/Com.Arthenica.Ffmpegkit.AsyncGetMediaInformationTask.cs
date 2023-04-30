using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AsyncGetMediaInformationTask']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/AsyncGetMediaInformationTask", DoNotGenerateAcw=true)]
	public partial class AsyncGetMediaInformationTask : global::Java.Lang.Object, global::Java.Lang.IRunnable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/AsyncGetMediaInformationTask", typeof (AsyncGetMediaInformationTask));

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

		protected AsyncGetMediaInformationTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AsyncGetMediaInformationTask']/constructor[@name='AsyncGetMediaInformationTask' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformationSession']]"
		[Register (".ctor", "(Lcom/arthenica/ffmpegkit/MediaInformationSession;)V", "")]
		public unsafe AsyncGetMediaInformationTask (global::Com.Arthenica.Ffmpegkit.MediaInformationSession? mediaInformationSession) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/arthenica/ffmpegkit/MediaInformationSession;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaInformationSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaInformationSession).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaInformationSession);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AsyncGetMediaInformationTask']/constructor[@name='AsyncGetMediaInformationTask' and count(parameter)=2 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformationSession'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Lcom/arthenica/ffmpegkit/MediaInformationSession;Ljava/lang/Integer;)V", "")]
		public unsafe AsyncGetMediaInformationTask (global::Com.Arthenica.Ffmpegkit.MediaInformationSession? mediaInformationSession, global::Java.Lang.Integer? waitTimeout) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/arthenica/ffmpegkit/MediaInformationSession;Ljava/lang/Integer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mediaInformationSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaInformationSession).Handle);
				__args [1] = new JniArgumentValue ((waitTimeout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) waitTimeout).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaInformationSession);
				global::System.GC.KeepAlive (waitTimeout);
			}
		}

		static Delegate? cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AsyncGetMediaInformationTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AsyncGetMediaInformationTask']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
