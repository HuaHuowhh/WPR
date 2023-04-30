using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='PackageLoader']"
	[Register ("com/arthenica/smartexception/PackageLoader", "", "Com.Arthenica.Smartexception.IPackageLoaderInvoker")]
	public partial interface IPackageLoader : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='PackageLoader']/method[@name='getPackage' and count(parameter)=2 and parameter[1][@type='java.lang.ClassLoader'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "GetGetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_Handler:Com.Arthenica.Smartexception.IPackageLoaderInvoker, com.arthenica.smartexception")]
		global::Java.Lang.Package? GetPackage (global::Java.Lang.ClassLoader? p0, string? p1);

	}

	[global::Android.Runtime.Register ("com/arthenica/smartexception/PackageLoader", DoNotGenerateAcw=true)]
	internal partial class IPackageLoaderInvoker : global::Java.Lang.Object, IPackageLoader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/PackageLoader", typeof (IPackageLoaderInvoker));

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

		public static IPackageLoader? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPackageLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.arthenica.smartexception.PackageLoader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPackageLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_Handler ()
		{
			if (cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ == null)
				cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_);
			return cb_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_;
		}

		static IntPtr n_GetPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IPackageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPackage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_;
		public unsafe global::Java.Lang.Package? GetPackage (global::Java.Lang.ClassLoader? p0, string? p1)
		{
			if (id_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ == IntPtr.Zero)
				id_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Package> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackage_Ljava_lang_ClassLoader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
