using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='FFprobeSessionCompleteCallback']"
	[Register ("com/arthenica/ffmpegkit/FFprobeSessionCompleteCallback", "", "Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallbackInvoker")]
	public partial interface IFFprobeSessionCompleteCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='FFprobeSessionCompleteCallback']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFprobeSession']]"
		[Register ("apply", "(Lcom/arthenica/ffmpegkit/FFprobeSession;)V", "GetApply_Lcom_arthenica_ffmpegkit_FFprobeSession_Handler:Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallbackInvoker, com.arthenica.ffmpegkit")]
		void Apply (global::Com.Arthenica.Ffmpegkit.FFprobeSession? session);

	}

	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/FFprobeSessionCompleteCallback", DoNotGenerateAcw=true)]
	internal partial class IFFprobeSessionCompleteCallbackInvoker : global::Java.Lang.Object, IFFprobeSessionCompleteCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/FFprobeSessionCompleteCallback", typeof (IFFprobeSessionCompleteCallbackInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IFFprobeSessionCompleteCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFFprobeSessionCompleteCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFFprobeSessionCompleteCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_;
#pragma warning disable 0169
		static Delegate GetApply_Lcom_arthenica_ffmpegkit_FFprobeSession_Handler ()
		{
			if (cb_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_ == null)
				cb_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Apply_Lcom_arthenica_ffmpegkit_FFprobeSession_);
			return cb_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_;
		}

		static void n_Apply_Lcom_arthenica_ffmpegkit_FFprobeSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_session)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var session = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (native_session, JniHandleOwnership.DoNotTransfer);
			__this.Apply (session);
		}
#pragma warning restore 0169

		IntPtr id_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_;
		public unsafe void Apply (global::Com.Arthenica.Ffmpegkit.FFprobeSession? session)
		{
			if (id_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_ == IntPtr.Zero)
				id_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/arthenica/ffmpegkit/FFprobeSession;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lcom_arthenica_ffmpegkit_FFprobeSession_, __args);
		}

	}
}
