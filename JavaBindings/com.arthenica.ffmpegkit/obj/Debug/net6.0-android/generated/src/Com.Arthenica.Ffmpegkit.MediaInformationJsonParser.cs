using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationJsonParser']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/MediaInformationJsonParser", DoNotGenerateAcw=true)]
	public partial class MediaInformationJsonParser : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationJsonParser']/field[@name='KEY_CHAPTERS']"
		[Register ("KEY_CHAPTERS")]
		public const string KeyChapters = (string) "chapters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationJsonParser']/field[@name='KEY_STREAMS']"
		[Register ("KEY_STREAMS")]
		public const string KeyStreams = (string) "streams";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/MediaInformationJsonParser", typeof (MediaInformationJsonParser));

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

		protected MediaInformationJsonParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationJsonParser']/constructor[@name='MediaInformationJsonParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaInformationJsonParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationJsonParser']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("from", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformation;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformation? From (string? ffprobeJsonOutput)
		{
			const string __id = "from.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformation;";
			IntPtr native_ffprobeJsonOutput = JNIEnv.NewString ((string?)ffprobeJsonOutput);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ffprobeJsonOutput);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_ffprobeJsonOutput);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformationJsonParser']/method[@name='fromWithError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromWithError", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformation;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformation? FromWithError (string? ffprobeJsonOutput)
		{
			const string __id = "fromWithError.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformation;";
			IntPtr native_ffprobeJsonOutput = JNIEnv.NewString ((string?)ffprobeJsonOutput);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ffprobeJsonOutput);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_ffprobeJsonOutput);
			}
		}

	}
}
