using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/Abi", DoNotGenerateAcw=true)]
	public sealed partial class Abi : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_ARM']"
		[Register ("ABI_ARM")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiArm {
			get {
				const string __id = "ABI_ARM.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_ARM64_V8A']"
		[Register ("ABI_ARM64_V8A")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiArm64V8a {
			get {
				const string __id = "ABI_ARM64_V8A.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_ARMV7A']"
		[Register ("ABI_ARMV7A")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiArmv7a {
			get {
				const string __id = "ABI_ARMV7A.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_ARMV7A_NEON']"
		[Register ("ABI_ARMV7A_NEON")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiArmv7aNeon {
			get {
				const string __id = "ABI_ARMV7A_NEON.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_UNKNOWN']"
		[Register ("ABI_UNKNOWN")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiUnknown {
			get {
				const string __id = "ABI_UNKNOWN.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_X86']"
		[Register ("ABI_X86")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiX86 {
			get {
				const string __id = "ABI_X86.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/field[@name='ABI_X86_64']"
		[Register ("ABI_X86_64")]
		public static global::Com.Arthenica.Ffmpegkit.Abi? AbiX8664 {
			get {
				const string __id = "ABI_X86_64.Lcom/arthenica/ffmpegkit/Abi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/Abi", typeof (Abi));

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

		internal Abi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/method[@name='from' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("from", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/Abi;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.Abi? From (string? abiName)
		{
			const string __id = "from.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/Abi;";
			IntPtr native_abiName = JNIEnv.NewString ((string?)abiName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_abiName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_abiName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/Abi;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.Abi? ValueOf (string? name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/Abi;";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Abi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Abi']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/arthenica/ffmpegkit/Abi;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.Abi[]? Values ()
		{
			const string __id = "values.()[Lcom/arthenica/ffmpegkit/Abi;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Arthenica.Ffmpegkit.Abi[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Arthenica.Ffmpegkit.Abi));
			} finally {
			}
		}

	}
}
