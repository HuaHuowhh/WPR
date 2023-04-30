using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/AbstractExceptions", DoNotGenerateAcw=true)]
	public abstract partial class AbstractExceptions : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/field[@name='DEFAULT_IGNORE_ALL_CAUSES']"
		[Register ("DEFAULT_IGNORE_ALL_CAUSES")]
		public const bool DefaultIgnoreAllCauses = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/field[@name='DEFAULT_MAX_DEPTH']"
		[Register ("DEFAULT_MAX_DEPTH")]
		public const int DefaultMaxDepth = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/field[@name='DEFAULT_PRINT_MODULE_NAME']"
		[Register ("DEFAULT_PRINT_MODULE_NAME")]
		public const bool DefaultPrintModuleName = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/field[@name='DEFAULT_PRINT_PACKAGE_INFORMATION']"
		[Register ("DEFAULT_PRINT_PACKAGE_INFORMATION")]
		public const bool DefaultPrintPackageInformation = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/field[@name='DEFAULT_PRINT_SUPPRESSED_EXCEPTIONS']"
		[Register ("DEFAULT_PRINT_SUPPRESSED_EXCEPTIONS")]
		public const bool DefaultPrintSuppressedExceptions = (bool) true;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/AbstractExceptions", typeof (AbstractExceptions));

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

		protected AbstractExceptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/constructor[@name='AbstractExceptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractExceptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getIgnoreAllCauses' and count(parameter)=0]"
			[Register ("getIgnoreAllCauses", "()Z", "")]
			get {
				const string __id = "getIgnoreAllCauses.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='setIgnoreAllCauses' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		public static unsafe bool PrintModuleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getPrintModuleName' and count(parameter)=0]"
			[Register ("getPrintModuleName", "()Z", "")]
			get {
				const string __id = "getPrintModuleName.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='setPrintModuleName' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrintModuleName", "(Z)V", "")]
			set {
				const string __id = "setPrintModuleName.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool PrintPackageInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='isPrintPackageInformation' and count(parameter)=0]"
			[Register ("isPrintPackageInformation", "()Z", "")]
			get {
				const string __id = "isPrintPackageInformation.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='setPrintPackageInformation' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getPrintSuppressedExceptions' and count(parameter)=0]"
			[Register ("getPrintSuppressedExceptions", "()Z", "")]
			get {
				const string __id = "getPrintSuppressedExceptions.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='setPrintSuppressedExceptions' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		public static unsafe global::Com.Arthenica.Smartexception.IStackTraceElementSerializer? StackTraceElementSerializer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceElementSerializer' and count(parameter)=0]"
			[Register ("getStackTraceElementSerializer", "()Lcom/arthenica/smartexception/StackTraceElementSerializer;", "")]
			get {
				const string __id = "getStackTraceElementSerializer.()Lcom/arthenica/smartexception/StackTraceElementSerializer;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IStackTraceElementSerializer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='setStackTraceElementSerializer' and count(parameter)=1 and parameter[1][@type='com.arthenica.smartexception.StackTraceElementSerializer']]"
			[Register ("setStackTraceElementSerializer", "(Lcom/arthenica/smartexception/StackTraceElementSerializer;)V", "")]
			set {
				const string __id = "setStackTraceElementSerializer.(Lcom/arthenica/smartexception/StackTraceElementSerializer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='appendStackTraceGroupElement' and count(parameter)=7 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.StackTraceElement'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='java.lang.String']]"
		[Register ("appendStackTraceGroupElement", "(Ljava/lang/StringBuilder;Ljava/lang/String;ILjava/lang/StackTraceElement;ZZLjava/lang/String;)I", "")]
		public static unsafe int AppendStackTraceGroupElement (global::Java.Lang.StringBuilder? stringBuilder, string? currentGroupPackage, int numberOfElementsInTheCurrentGroup, global::Java.Lang.StackTraceElement? firstStackTraceElementInTheGroup, bool printModuleName, bool printPackageInformation, string? prefix)
		{
			const string __id = "appendStackTraceGroupElement.(Ljava/lang/StringBuilder;Ljava/lang/String;ILjava/lang/StackTraceElement;ZZLjava/lang/String;)I";
			IntPtr native_currentGroupPackage = JNIEnv.NewString ((string?)currentGroupPackage);
			IntPtr native_prefix = JNIEnv.NewString ((string?)prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((stringBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stringBuilder).Handle);
				__args [1] = new JniArgumentValue (native_currentGroupPackage);
				__args [2] = new JniArgumentValue (numberOfElementsInTheCurrentGroup);
				__args [3] = new JniArgumentValue ((firstStackTraceElementInTheGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstStackTraceElementInTheGroup).Handle);
				__args [4] = new JniArgumentValue (printModuleName);
				__args [5] = new JniArgumentValue (printPackageInformation);
				__args [6] = new JniArgumentValue (native_prefix);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_currentGroupPackage);
				JNIEnv.DeleteLocalRef (native_prefix);
				global::System.GC.KeepAlive (stringBuilder);
				global::System.GC.KeepAlive (firstStackTraceElementInTheGroup);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='clearGroupPackages' and count(parameter)=0]"
		[Register ("clearGroupPackages", "()V", "")]
		public static unsafe void ClearGroupPackages ()
		{
			const string __id = "clearGroupPackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='clearIgnorePackages' and count(parameter)=0]"
		[Register ("clearIgnorePackages", "()V", "")]
		public static unsafe void ClearIgnorePackages ()
		{
			const string __id = "clearIgnorePackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='clearRootPackages' and count(parameter)=0]"
		[Register ("clearRootPackages", "()V", "")]
		public static unsafe void ClearRootPackages ()
		{
			const string __id = "clearRootPackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='containsCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='containsCause' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='containsPackage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("containsPackage", "(Ljava/lang/String;Ljava/util/Set;)Z", "")]
		public static unsafe bool ContainsPackage (string? fullClassName, global::System.Collections.Generic.ICollection<string>? packageSet)
		{
			const string __id = "containsPackage.(Ljava/lang/String;Ljava/util/Set;)Z";
			IntPtr native_fullClassName = JNIEnv.NewString ((string?)fullClassName);
			IntPtr native_packageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (packageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fullClassName);
				__args [1] = new JniArgumentValue (native_packageSet);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fullClassName);
				JNIEnv.DeleteLocalRef (native_packageSet);
				global::System.GC.KeepAlive (packageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getAllMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getAllMessages' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.StringBuilder']]"
		[Register ("getAllMessages", "(Ljava/lang/Throwable;Ljava/lang/StringBuilder;)V", "")]
		public static unsafe void GetAllMessages (global::Java.Lang.Throwable? throwable, global::Java.Lang.StringBuilder? messageBuilder)
		{
			const string __id = "getAllMessages.(Ljava/lang/Throwable;Ljava/lang/StringBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue ((messageBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messageBuilder).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (messageBuilder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getCause' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getContainingPackage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getContainingPackage", "(Ljava/lang/String;Ljava/util/Set;)Ljava/lang/String;", "")]
		public static unsafe string? GetContainingPackage (string? fullClassName, global::System.Collections.Generic.ICollection<string>? packageSet)
		{
			const string __id = "getContainingPackage.(Ljava/lang/String;Ljava/util/Set;)Ljava/lang/String;";
			IntPtr native_fullClassName = JNIEnv.NewString ((string?)fullClassName);
			IntPtr native_packageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (packageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fullClassName);
				__args [1] = new JniArgumentValue (native_packageSet);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fullClassName);
				JNIEnv.DeleteLocalRef (native_packageSet);
				global::System.GC.KeepAlive (packageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTrace' and count(parameter)=2 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='int']]"
		[Register ("getStackTrace", "(Lcom/arthenica/smartexception/ThrowableWrapper;I)[Ljava/lang/StackTraceElement;", "")]
		public static unsafe global::Java.Lang.StackTraceElement[]? GetStackTrace (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, int maxDepth)
		{
			const string __id = "getStackTrace.(Lcom/arthenica/smartexception/ThrowableWrapper;I)[Ljava/lang/StackTraceElement;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.StackTraceElement[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.StackTraceElement));
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTrace' and count(parameter)=3 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStackTrace", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;)[Ljava/lang/StackTraceElement;", "")]
		public static unsafe global::Java.Lang.StackTraceElement[]? GetStackTrace (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet)
		{
			const string __id = "getStackTrace.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;)[Ljava/lang/StackTraceElement;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_ignorePackageSet);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.StackTraceElement[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.StackTraceElement));
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackageSet);
				JNIEnv.DeleteLocalRef (native_ignorePackageSet);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (rootPackageSet);
				global::System.GC.KeepAlive (ignorePackageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=1 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=2 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Z)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, bool ignoreAllCauses)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (ignoreAllCauses);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=11 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[6][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[7][@type='int'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='boolean'] and parameter[11][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;ZZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, bool isCause, bool isSuppressed, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, int maxDepth, bool ignoreAllCauses, bool printPackageInformation, bool printModuleName, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;ZZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (isCause);
				__args [2] = new JniArgumentValue (isSuppressed);
				__args [3] = new JniArgumentValue (native_rootPackageSet);
				__args [4] = new JniArgumentValue (native_groupPackageSet);
				__args [5] = new JniArgumentValue (native_ignorePackageSet);
				__args [6] = new JniArgumentValue (maxDepth);
				__args [7] = new JniArgumentValue (ignoreAllCauses);
				__args [8] = new JniArgumentValue (printPackageInformation);
				__args [9] = new JniArgumentValue (printModuleName);
				__args [10] = new JniArgumentValue (printSuppressedExceptions);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=2 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='int']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;I)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, int maxDepth)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=3 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;IZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, int maxDepth, bool ignoreAllCauses)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;IZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				__args [2] = new JniArgumentValue (ignoreAllCauses);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=4 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;IZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, int maxDepth, bool ignoreAllCauses, bool printPackageInformation)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;IZZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (maxDepth);
				__args [2] = new JniArgumentValue (ignoreAllCauses);
				__args [3] = new JniArgumentValue (printPackageInformation);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=5 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;IZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, int maxDepth, bool ignoreAllCauses, bool printPackageInformation, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;IZZZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=2 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, string? rootPackage)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_rootPackage = JNIEnv.NewString ((string?)rootPackage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackage);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rootPackage);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=12 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[6][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[7][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[8][@type='int'] and parameter[9][@type='boolean'] and parameter[10][@type='boolean'] and parameter[11][@type='boolean'] and parameter[12][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;ZZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, string? prefix, bool isCause, bool isSuppressed, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, int maxDepth, bool ignoreAllCauses, bool printPackageInformation, bool printModuleName, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;ZZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZZ)Ljava/lang/String;";
			IntPtr native_prefix = JNIEnv.NewString ((string?)prefix);
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (native_prefix);
				__args [2] = new JniArgumentValue (isCause);
				__args [3] = new JniArgumentValue (isSuppressed);
				__args [4] = new JniArgumentValue (native_rootPackageSet);
				__args [5] = new JniArgumentValue (native_groupPackageSet);
				__args [6] = new JniArgumentValue (native_ignorePackageSet);
				__args [7] = new JniArgumentValue (maxDepth);
				__args [8] = new JniArgumentValue (ignoreAllCauses);
				__args [9] = new JniArgumentValue (printPackageInformation);
				__args [10] = new JniArgumentValue (printModuleName);
				__args [11] = new JniArgumentValue (printSuppressedExceptions);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_rootPackageSet);
				JNIEnv.DeleteLocalRef (native_groupPackageSet);
				JNIEnv.DeleteLocalRef (native_ignorePackageSet);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (rootPackageSet);
				global::System.GC.KeepAlive (groupPackageSet);
				global::System.GC.KeepAlive (ignorePackageSet);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=3 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, string? rootPackage, string? groupPackage)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_rootPackage = JNIEnv.NewString ((string?)rootPackage);
			IntPtr native_groupPackage = JNIEnv.NewString ((string?)groupPackage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=4 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=5 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Z)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, bool ignoreAllCauses)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;Z)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=6 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, bool ignoreAllCauses, bool printPackageInformation)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=7 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, bool ignoreAllCauses, bool printPackageInformation, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;ZZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=7 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, int maxDepth, bool ignoreAllCauses, bool printPackageInformation)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				__args [4] = new JniArgumentValue (maxDepth);
				__args [5] = new JniArgumentValue (ignoreAllCauses);
				__args [6] = new JniArgumentValue (printPackageInformation);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=8 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, int maxDepth, bool ignoreAllCauses, bool printPackageInformation, bool printModuleName)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				__args [4] = new JniArgumentValue (maxDepth);
				__args [5] = new JniArgumentValue (ignoreAllCauses);
				__args [6] = new JniArgumentValue (printPackageInformation);
				__args [7] = new JniArgumentValue (printModuleName);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='getStackTraceString' and count(parameter)=9 and parameter[1][@type='com.arthenica.smartexception.ThrowableWrapper'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean']]"
		[Register ("getStackTraceString", "(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZZ)Ljava/lang/String;", "")]
		public static unsafe string? GetStackTraceString (global::Com.Arthenica.Smartexception.ThrowableWrapper? throwable, global::System.Collections.Generic.ICollection<string>? rootPackageSet, global::System.Collections.Generic.ICollection<string>? groupPackageSet, global::System.Collections.Generic.ICollection<string>? ignorePackageSet, int maxDepth, bool ignoreAllCauses, bool printPackageInformation, bool printModuleName, bool printSuppressedExceptions)
		{
			const string __id = "getStackTraceString.(Lcom/arthenica/smartexception/ThrowableWrapper;Ljava/util/Set;Ljava/util/Set;Ljava/util/Set;IZZZZ)Ljava/lang/String;";
			IntPtr native_rootPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (rootPackageSet);
			IntPtr native_groupPackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (groupPackageSet);
			IntPtr native_ignorePackageSet = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (ignorePackageSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwable).Handle);
				__args [1] = new JniArgumentValue (native_rootPackageSet);
				__args [2] = new JniArgumentValue (native_groupPackageSet);
				__args [3] = new JniArgumentValue (native_ignorePackageSet);
				__args [4] = new JniArgumentValue (maxDepth);
				__args [5] = new JniArgumentValue (ignoreAllCauses);
				__args [6] = new JniArgumentValue (printPackageInformation);
				__args [7] = new JniArgumentValue (printModuleName);
				__args [8] = new JniArgumentValue (printSuppressedExceptions);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmpty (string? value)
		{
			const string __id = "isEmpty.(Ljava/lang/String;)Z";
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='libraryName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("libraryName", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string? LibraryName (global::Java.Lang.Class? type)
		{
			const string __id = "libraryName.(Ljava/lang/Class;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='packageInformation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("packageInformation", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? PackageInformation (string? libraryName, string? version)
		{
			const string __id = "packageInformation.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_libraryName = JNIEnv.NewString ((string?)libraryName);
			IntPtr native_version = JNIEnv.NewString ((string?)version);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_libraryName);
				__args [1] = new JniArgumentValue (native_version);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_libraryName);
				JNIEnv.DeleteLocalRef (native_version);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='packageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("packageName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? PackageName (string? className)
		{
			const string __id = "packageName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_className = JNIEnv.NewString ((string?)className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_className);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='registerGroupPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='registerIgnorePackage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='registerRootPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='searchCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='searchCause' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='searchCause' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='searchCause' and count(parameter)=4 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='AbstractExceptions']/method[@name='version' and count(parameter)=3 and parameter[1][@type='com.arthenica.smartexception.PackageLoader'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("version", "(Lcom/arthenica/smartexception/PackageLoader;Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? Version (global::Com.Arthenica.Smartexception.IPackageLoader? packageLoader, global::Java.Lang.Class? type, string? packageName)
		{
			const string __id = "version.(Lcom/arthenica/smartexception/PackageLoader;Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_packageName = JNIEnv.NewString ((string?)packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((packageLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packageLoader).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [2] = new JniArgumentValue (native_packageName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				global::System.GC.KeepAlive (packageLoader);
				global::System.GC.KeepAlive (type);
			}
		}

	}

	[global::Android.Runtime.Register ("com/arthenica/smartexception/AbstractExceptions", DoNotGenerateAcw=true)]
	internal partial class AbstractExceptionsInvoker : AbstractExceptions {
		public AbstractExceptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/AbstractExceptions", typeof (AbstractExceptionsInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
