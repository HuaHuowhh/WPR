using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception.Java {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/java/Exceptions", DoNotGenerateAcw=true)]
	public partial class Exceptions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/java/Exceptions", typeof (Exceptions));

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

		protected Exceptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/constructor[@name='Exceptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Exceptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe bool IgnoreAllCauses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getIgnoreAllCauses' and count(parameter)=0]"
			[Register ("getIgnoreAllCauses", "()Z", "")]
			get {
				const string __id = "getIgnoreAllCauses.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='setIgnoreAllCauses' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIgnoreAllCauses", "(Z)V", "")]
			set {
				const string __id = "setIgnoreAllCauses.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool PrintPackageInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='isPrintPackageInformation' and count(parameter)=0]"
			[Register ("isPrintPackageInformation", "()Z", "")]
			get {
				const string __id = "isPrintPackageInformation.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='setPrintPackageInformation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrintPackageInformation", "(Z)V", "")]
			set {
				const string __id = "setPrintPackageInformation.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool PrintSuppressedExceptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getPrintSuppressedExceptions' and count(parameter)=0]"
			[Register ("getPrintSuppressedExceptions", "()Z", "")]
			get {
				const string __id = "getPrintSuppressedExceptions.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='setPrintSuppressedExceptions' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrintSuppressedExceptions", "(Z)V", "")]
			set {
				const string __id = "setPrintSuppressedExceptions.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='clearGroupPackages' and count(parameter)=0]"
		[Register ("clearGroupPackages", "()V", "")]
		public static unsafe void ClearGroupPackages ()
		{
			const string __id = "clearGroupPackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='clearIgnorePackages' and count(parameter)=0]"
		[Register ("clearIgnorePackages", "()V", "")]
		public static unsafe void ClearIgnorePackages ()
		{
			const string __id = "clearIgnorePackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='clearRootPackages' and count(parameter)=0]"
		[Register ("clearRootPackages", "()V", "")]
		public static unsafe void ClearRootPackages ()
		{
			const string __id = "clearRootPackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='containsCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("containsCause", "(Ljava/lang/Throwable;Ljava/lang/Class;)Z", "")]
		public static unsafe bool ContainsCause (global::Java.Lang.Throwable? throwable, global::Java.Lang.Class? causeClass)
		{
			const string __id = "containsCause.(Ljava/lang/Throwable;Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((causeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causeClass).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (causeClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='containsCause' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("containsCause", "(Ljava/lang/Throwable;Ljava/lang/Class;Ljava/lang/String;)Z", "")]
		public static unsafe bool ContainsCause (global::Java.Lang.Throwable? throwable, global::Java.Lang.Class? causeClass, string? causeMessage)
		{
			const string __id = "containsCause.(Ljava/lang/Throwable;Ljava/lang/Class;Ljava/lang/String;)Z";
			IntPtr native_causeMessage = JNIEnv.NewString ((string?)causeMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((causeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causeClass).Handle);
				__args [2] = new JniArgumentValue (native_causeMessage);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_causeMessage);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (causeClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getAllMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getAllMessages", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string? GetAllMessages (global::Java.Lang.Throwable? throwable)
		{
			const string __id = "getAllMessages.(Ljava/lang/Throwable;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getCause' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable? GetCause (global::Java.Lang.Throwable? throwable)
		{
			const string __id = "getCause.(Ljava/lang/Throwable;)Ljava/lang/Throwable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int']]"
		[Register ("getCause", "(Ljava/lang/Throwable;I)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable? GetCause (global::Java.Lang.Throwable? throwable, int maxDepth)
		{
			const string __id = "getCause.(Ljava/lang/Throwable;I)Ljava/lang/Throwable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Z)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, bool ignoreAllCauses)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (ignoreAllCauses);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;I)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, int maxDepth)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;IZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, int maxDepth, bool ignoreAllCauses)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;IZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				__args [2] = new JniArgumentValue (ignoreAllCauses);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=4 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;IZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, int maxDepth, bool ignoreAllCauses, bool printPackageInformation)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;IZZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				__args [2] = new JniArgumentValue (ignoreAllCauses);
				__args [3] = new JniArgumentValue (printPackageInformation);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=5 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;IZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, int maxDepth, bool ignoreAllCauses, bool printPackageInformation, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;IZZZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				__args [2] = new JniArgumentValue (ignoreAllCauses);
				__args [3] = new JniArgumentValue (printPackageInformation);
				__args [4] = new JniArgumentValue (printSuppressedExceptions);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, string? rootPackage)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_rootPackage = JNIEnv.NewString ((string?)rootPackage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackage);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackage);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, string? rootPackage, string? groupPackage)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_rootPackage = JNIEnv.NewString ((string?)rootPackage);
			IntPtr native_groupPackage = JNIEnv.NewString ((string?)groupPackage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackage);
				__args [2] = new JniArgumentValue (native_groupPackage);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackage);
				JNIEnv.DeleteLocalRef (native_groupPackage);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=4 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackageSet);
				JNIEnv.DeleteLocalRef (native_groupPackageSet);
				JNIEnv.DeleteLocalRef (native_ignorePackageSet);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (rootPackageSet);
				global::System.GC.KeepAlive (groupPackageSet);
				global::System.GC.KeepAlive (ignorePackageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=5 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Z)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, bool ignoreAllCauses)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Z)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				__args [4] = new JniArgumentValue (ignoreAllCauses);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackageSet);
				JNIEnv.DeleteLocalRef (native_groupPackageSet);
				JNIEnv.DeleteLocalRef (native_ignorePackageSet);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (rootPackageSet);
				global::System.GC.KeepAlive (groupPackageSet);
				global::System.GC.KeepAlive (ignorePackageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=6 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, bool ignoreAllCauses, bool printPackageInformation)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				__args [4] = new JniArgumentValue (ignoreAllCauses);
				__args [5] = new JniArgumentValue (printPackageInformation);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackageSet);
				JNIEnv.DeleteLocalRef (native_groupPackageSet);
				JNIEnv.DeleteLocalRef (native_ignorePackageSet);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (rootPackageSet);
				global::System.GC.KeepAlive (groupPackageSet);
				global::System.GC.KeepAlive (ignorePackageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='getStackTraceString' and count(parameter)=7 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("getStackTraceString", "(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Java.Lang.Throwable? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, bool ignoreAllCauses, bool printPackageInformation, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Ljava/lang/Throwable;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				__args [4] = new JniArgumentValue (ignoreAllCauses);
				__args [5] = new JniArgumentValue (printPackageInformation);
				__args [6] = new JniArgumentValue (printSuppressedExceptions);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackageSet);
				JNIEnv.DeleteLocalRef (native_groupPackageSet);
				JNIEnv.DeleteLocalRef (native_ignorePackageSet);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (rootPackageSet);
				global::System.GC.KeepAlive (groupPackageSet);
				global::System.GC.KeepAlive (ignorePackageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='registerGroupPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerGroupPackage", "(Ljava/lang/String;)V", "")]
		public static unsafe void RegisterGroupPackage (string? packageString)
		{
			const string __id = "registerGroupPackage.(Ljava/lang/String;)V";
			IntPtr native_packageString = JNIEnv.NewString ((string?)packageString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageString);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='registerIgnorePackage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("registerIgnorePackage", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void RegisterIgnorePackage (string? packageString, bool ignoreCauseClasses)
		{
			const string __id = "registerIgnorePackage.(Ljava/lang/String;Z)V";
			IntPtr native_packageString = JNIEnv.NewString ((string?)packageString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_packageString);
				__args [1] = new JniArgumentValue (ignoreCauseClasses);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='registerRootPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerRootPackage", "(Ljava/lang/String;)V", "")]
		public static unsafe void RegisterRootPackage (string? packageString)
		{
			const string __id = "registerRootPackage.(Ljava/lang/String;)V";
			IntPtr native_packageString = JNIEnv.NewString ((string?)packageString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packageString);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='searchCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("searchCause", "(Ljava/lang/Throwable;Ljava/lang/Class;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable? SearchCause (global::Java.Lang.Throwable? throwable, global::Java.Lang.Class? causeClass)
		{
			const string __id = "searchCause.(Ljava/lang/Throwable;Ljava/lang/Class;)Ljava/lang/Throwable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((causeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causeClass).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (causeClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='searchCause' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='int']]"
		[Register ("searchCause", "(Ljava/lang/Throwable;Ljava/lang/Class;I)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable? SearchCause (global::Java.Lang.Throwable? throwable, global::Java.Lang.Class? causeClass, int maxDepth)
		{
			const string __id = "searchCause.(Ljava/lang/Throwable;Ljava/lang/Class;I)Ljava/lang/Throwable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((causeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causeClass).Handle);
				__args [2] = new JniArgumentValue (maxDepth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (causeClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='searchCause' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("searchCause", "(Ljava/lang/Throwable;Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable? SearchCause (global::Java.Lang.Throwable? throwable, global::Java.Lang.Class? causeClass, string? causeMessage)
		{
			const string __id = "searchCause.(Ljava/lang/Throwable;Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Throwable;";
			IntPtr native_causeMessage = JNIEnv.NewString ((string?)causeMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((causeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causeClass).Handle);
				__args [2] = new JniArgumentValue (native_causeMessage);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_causeMessage);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (causeClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='Exceptions']/method[@name='searchCause' and count(parameter)=4 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("searchCause", "(Ljava/lang/Throwable;Ljava/lang/Class;Ljava/lang/String;I)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable? SearchCause (global::Java.Lang.Throwable? throwable, global::Java.Lang.Class? causeClass, string? causeMessage, int maxDepth)
		{
			const string __id = "searchCause.(Ljava/lang/Throwable;Ljava/lang/Class;Ljava/lang/String;I)Ljava/lang/Throwable;";
			IntPtr native_causeMessage = JNIEnv.NewString ((string?)causeMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((causeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causeClass).Handle);
				__args [2] = new JniArgumentValue (native_causeMessage);
				__args [3] = new JniArgumentValue (maxDepth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_causeMessage);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (causeClass);
			}
		}

	}
}
