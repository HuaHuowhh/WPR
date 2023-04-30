using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='StackTraceElementWrapper']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/StackTraceElementWrapper", DoNotGenerateAcw=true)]
	public partial class StackTraceElementWrapper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/StackTraceElementWrapper", typeof (StackTraceElementWrapper));

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

		protected StackTraceElementWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='StackTraceElementWrapper']/constructor[@name='StackTraceElementWrapper' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
		[Register (".ctor", "(Ljava/lang/StackTraceElement;)V", "")]
		public unsafe StackTraceElementWrapper (global::Java.Lang.StackTraceElement? stackTraceElement) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/StackTraceElement;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stackTraceElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stackTraceElement).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (stackTraceElement);
			}
		}

		static Delegate? cb_getStackTraceElement;
#pragma warning disable 0169
		static Delegate GetGetStackTraceElementHandler ()
		{
			if (cb_getStackTraceElement == null)
				cb_getStackTraceElement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStackTraceElement);
			return cb_getStackTraceElement;
		}

		static IntPtr n_GetStackTraceElement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.StackTraceElementWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.StackTraceElement);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.StackTraceElement? StackTraceElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/class[@name='StackTraceElementWrapper']/method[@name='getStackTraceElement' and count(parameter)=0]"
			[Register ("getStackTraceElement", "()Ljava/lang/StackTraceElement;", "GetGetStackTraceElementHandler")]
			get {
				const string __id = "getStackTraceElement.()Ljava/lang/StackTraceElement;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
