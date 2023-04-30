using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/LogRedirectionStrategy", DoNotGenerateAcw=true)]
	public sealed partial class LogRedirectionStrategy : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/field[@name='ALWAYS_PRINT_LOGS']"
		[Register ("ALWAYS_PRINT_LOGS")]
		public static global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? AlwaysPrintLogs {
			get {
				const string __id = "ALWAYS_PRINT_LOGS.Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/field[@name='NEVER_PRINT_LOGS']"
		[Register ("NEVER_PRINT_LOGS")]
		public static global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? NeverPrintLogs {
			get {
				const string __id = "NEVER_PRINT_LOGS.Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/field[@name='PRINT_LOGS_WHEN_GLOBAL_CALLBACK_NOT_DEFINED']"
		[Register ("PRINT_LOGS_WHEN_GLOBAL_CALLBACK_NOT_DEFINED")]
		public static global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? PrintLogsWhenGlobalCallbackNotDefined {
			get {
				const string __id = "PRINT_LOGS_WHEN_GLOBAL_CALLBACK_NOT_DEFINED.Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/field[@name='PRINT_LOGS_WHEN_NO_CALLBACKS_DEFINED']"
		[Register ("PRINT_LOGS_WHEN_NO_CALLBACKS_DEFINED")]
		public static global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? PrintLogsWhenNoCallbacksDefined {
			get {
				const string __id = "PRINT_LOGS_WHEN_NO_CALLBACKS_DEFINED.Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/field[@name='PRINT_LOGS_WHEN_SESSION_CALLBACK_NOT_DEFINED']"
		[Register ("PRINT_LOGS_WHEN_SESSION_CALLBACK_NOT_DEFINED")]
		public static global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? PrintLogsWhenSessionCallbackNotDefined {
			get {
				const string __id = "PRINT_LOGS_WHEN_SESSION_CALLBACK_NOT_DEFINED.Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/LogRedirectionStrategy", typeof (LogRedirectionStrategy));

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

		internal LogRedirectionStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='LogRedirectionStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy[]? Values ()
		{
			const string __id = "values.()[Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy));
			} finally {
			}
		}

	}
}
