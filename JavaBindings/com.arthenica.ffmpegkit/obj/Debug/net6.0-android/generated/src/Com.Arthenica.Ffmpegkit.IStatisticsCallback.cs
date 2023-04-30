using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='StatisticsCallback']"
	[Register ("com/arthenica/ffmpegkit/StatisticsCallback", "", "Com.Arthenica.Ffmpegkit.IStatisticsCallbackInvoker")]
	public partial interface IStatisticsCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='StatisticsCallback']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.Statistics']]"
		[Register ("apply", "(Lcom/arthenica/ffmpegkit/Statistics;)V", "GetApply_Lcom_arthenica_ffmpegkit_Statistics_Handler:Com.Arthenica.Ffmpegkit.IStatisticsCallbackInvoker, com.arthenica.ffmpegkit")]
		void Apply (global::Com.Arthenica.Ffmpegkit.Statistics? statistics);

	}

	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/StatisticsCallback", DoNotGenerateAcw=true)]
	internal partial class IStatisticsCallbackInvoker : global::Java.Lang.Object, IStatisticsCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/StatisticsCallback", typeof (IStatisticsCallbackInvoker));

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

		public static IStatisticsCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatisticsCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.arthenica.ffmpegkit.StatisticsCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatisticsCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_apply_Lcom_arthenica_ffmpegkit_Statistics_;
#pragma warning disable 0169
		static Delegate GetApply_Lcom_arthenica_ffmpegkit_Statistics_Handler ()
		{
			if (cb_apply_Lcom_arthenica_ffmpegkit_Statistics_ == null)
				cb_apply_Lcom_arthenica_ffmpegkit_Statistics_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Apply_Lcom_arthenica_ffmpegkit_Statistics_);
			return cb_apply_Lcom_arthenica_ffmpegkit_Statistics_;
		}

		static void n_Apply_Lcom_arthenica_ffmpegkit_Statistics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_statistics)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IStatisticsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var statistics = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (native_statistics, JniHandleOwnership.DoNotTransfer);
			__this.Apply (statistics);
		}
#pragma warning restore 0169

		IntPtr id_apply_Lcom_arthenica_ffmpegkit_Statistics_;
		public unsafe void Apply (global::Com.Arthenica.Ffmpegkit.Statistics? statistics)
		{
			if (id_apply_Lcom_arthenica_ffmpegkit_Statistics_ == IntPtr.Zero)
				id_apply_Lcom_arthenica_ffmpegkit_Statistics_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/arthenica/ffmpegkit/Statistics;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((statistics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statistics).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lcom_arthenica_ffmpegkit_Statistics_, __args);
		}

	}
}
