using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception.Java {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaPackageLoader']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/java/JavaPackageLoader", DoNotGenerateAcw=true)]
	public partial class JavaPackageLoader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/java/JavaPackageLoader", typeof (JavaPackageLoader));

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

		protected JavaPackageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaPackageLoader']/constructor[@name='JavaPackageLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JavaPackageLoader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_Handler ()
		{
			if (cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ == null)
				cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_);
			return cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_;
		}

		static IntPtr n_GetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_classLoader, IntPtr native_className)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaPackageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var classLoader = global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (native_classLoader, JniHandleOwnership.DoNotTransfer);
			var className = JNIEnv.GetString (native_className, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPackage (classLoader, className));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaPackageLoader']/method[@name='getPackage' and count(parameter)=2 and parameter[1][@type='java.lang.ClassLoader'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "GetGetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Package? GetPackage (global::Java.Lang.ClassLoader? classLoader, string? className)
		{
			const string __id = "getPackage.(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;";
			IntPtr native_className = JNIEnv.NewString ((string?)className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((classLoader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classLoader).Handle);
				__args [1] = new JniArgumentValue (native_className);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Package> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				global::System.GC.KeepAlive (classLoader);
			}
		}

	}
}
