using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='ClassLoader']"
	[Register ("com/arthenica/smartexception/ClassLoader", "", "Com.Arthenica.Smartexception.IClassLoaderInvoker")]
	public partial interface IClassLoader : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='ClassLoader']/method[@name='loadClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", "GetLoadClass_Ljava_lang_String_Handler:Com.Arthenica.Smartexception.IClassLoaderInvoker, com.arthenica.smartexception")]
		global::Java.Lang.Class? LoadClass (string? p0);

	}

	[global::Android.Runtime.Register ("com/arthenica/smartexception/ClassLoader", DoNotGenerateAcw=true)]
	internal partial class IClassLoaderInvoker : global::Java.Lang.Object, IClassLoader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/ClassLoader", typeof (IClassLoaderInvoker));

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

		public static IClassLoader? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClassLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.arthenica.smartexception.ClassLoader'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClassLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_loadClass_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadClass_Ljava_lang_String_Handler ()
		{
			if (cb_loadClass_Ljava_lang_String_ == null)
				cb_loadClass_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LoadClass_Ljava_lang_String_);
			return cb_loadClass_Ljava_lang_String_;
		}

		static IntPtr n_LoadClass_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IClassLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadClass (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadClass_Ljava_lang_String_;
		public unsafe global::Java.Lang.Class? LoadClass (string? p0)
		{
			if (id_loadClass_Ljava_lang_String_ == IntPtr.Zero)
				id_loadClass_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadClass_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
