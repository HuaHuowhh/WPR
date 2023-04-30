using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/Signal", DoNotGenerateAcw=true)]
	public sealed partial class Signal : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/field[@name='SIGINT']"
		[Register ("SIGINT")]
		public static global::Com.Arthenica.Ffmpegkit.Signal? Sigint {
			get {
				const string __id = "SIGINT.Lcom/arthenica/ffmpegkit/Signal;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Signal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/field[@name='SIGPIPE']"
		[Register ("SIGPIPE")]
		public static global::Com.Arthenica.Ffmpegkit.Signal? Sigpipe {
			get {
				const string __id = "SIGPIPE.Lcom/arthenica/ffmpegkit/Signal;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Signal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/field[@name='SIGQUIT']"
		[Register ("SIGQUIT")]
		public static global::Com.Arthenica.Ffmpegkit.Signal? Sigquit {
			get {
				const string __id = "SIGQUIT.Lcom/arthenica/ffmpegkit/Signal;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Signal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/field[@name='SIGTERM']"
		[Register ("SIGTERM")]
		public static global::Com.Arthenica.Ffmpegkit.Signal? Sigterm {
			get {
				const string __id = "SIGTERM.Lcom/arthenica/ffmpegkit/Signal;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Signal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/field[@name='SIGXCPU']"
		[Register ("SIGXCPU")]
		public static global::Com.Arthenica.Ffmpegkit.Signal? Sigxcpu {
			get {
				const string __id = "SIGXCPU.Lcom/arthenica/ffmpegkit/Signal;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Signal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/Signal", typeof (Signal));

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

		internal Signal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/Signal;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.Signal? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/Signal;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Signal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Signal']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/arthenica/ffmpegkit/Signal;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.Signal[]? Values ()
		{
			const string __id = "values.()[Lcom/arthenica/ffmpegkit/Signal;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Arthenica.Ffmpegkit.Signal[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Arthenica.Ffmpegkit.Signal));
			} finally {
			}
		}

	}
}
