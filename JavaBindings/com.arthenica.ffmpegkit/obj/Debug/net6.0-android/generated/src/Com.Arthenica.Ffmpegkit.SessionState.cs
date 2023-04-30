using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/SessionState", DoNotGenerateAcw=true)]
	public sealed partial class SessionState : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']/field[@name='COMPLETED']"
		[Register ("COMPLETED")]
		public static global::Com.Arthenica.Ffmpegkit.SessionState? Completed {
			get {
				const string __id = "COMPLETED.Lcom/arthenica/ffmpegkit/SessionState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']/field[@name='CREATED']"
		[Register ("CREATED")]
		public static global::Com.Arthenica.Ffmpegkit.SessionState? Created {
			get {
				const string __id = "CREATED.Lcom/arthenica/ffmpegkit/SessionState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']/field[@name='FAILED']"
		[Register ("FAILED")]
		public static global::Com.Arthenica.Ffmpegkit.SessionState? Failed {
			get {
				const string __id = "FAILED.Lcom/arthenica/ffmpegkit/SessionState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']/field[@name='RUNNING']"
		[Register ("RUNNING")]
		public static global::Com.Arthenica.Ffmpegkit.SessionState? Running {
			get {
				const string __id = "RUNNING.Lcom/arthenica/ffmpegkit/SessionState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/SessionState", typeof (SessionState));

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

		internal SessionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/SessionState;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.SessionState? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/SessionState;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='SessionState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/arthenica/ffmpegkit/SessionState;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.SessionState[]? Values ()
		{
			const string __id = "values.()[Lcom/arthenica/ffmpegkit/SessionState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Arthenica.Ffmpegkit.SessionState[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Arthenica.Ffmpegkit.SessionState));
			} finally {
			}
		}

	}
}
