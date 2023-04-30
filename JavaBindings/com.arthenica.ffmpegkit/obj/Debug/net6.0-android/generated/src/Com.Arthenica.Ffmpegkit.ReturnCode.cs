using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/ReturnCode", DoNotGenerateAcw=true)]
	public partial class ReturnCode : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public static int Cancel {
			get {
				const string __id = "CANCEL.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "CANCEL.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static int Success {
			get {
				const string __id = "SUCCESS.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "SUCCESS.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/ReturnCode", typeof (ReturnCode));

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

		protected ReturnCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/constructor[@name='ReturnCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ReturnCode (int value) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_isValueCancel;
#pragma warning disable 0169
		static Delegate GetIsValueCancelHandler ()
		{
			if (cb_isValueCancel == null)
				cb_isValueCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValueCancel);
			return cb_isValueCancel;
		}

		static bool n_IsValueCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ReturnCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsValueCancel;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValueCancel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/method[@name='isValueCancel' and count(parameter)=0]"
			[Register ("isValueCancel", "()Z", "GetIsValueCancelHandler")]
			get {
				const string __id = "isValueCancel.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isValueError;
#pragma warning disable 0169
		static Delegate GetIsValueErrorHandler ()
		{
			if (cb_isValueError == null)
				cb_isValueError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValueError);
			return cb_isValueError;
		}

		static bool n_IsValueError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ReturnCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsValueError;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValueError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/method[@name='isValueError' and count(parameter)=0]"
			[Register ("isValueError", "()Z", "GetIsValueErrorHandler")]
			get {
				const string __id = "isValueError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isValueSuccess;
#pragma warning disable 0169
		static Delegate GetIsValueSuccessHandler ()
		{
			if (cb_isValueSuccess == null)
				cb_isValueSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValueSuccess);
			return cb_isValueSuccess;
		}

		static bool n_IsValueSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ReturnCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsValueSuccess;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValueSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/method[@name='isValueSuccess' and count(parameter)=0]"
			[Register ("isValueSuccess", "()Z", "GetIsValueSuccessHandler")]
			get {
				const string __id = "isValueSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetValue);
			return cb_getValue;
		}

		static int n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ReturnCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Value;
		}
#pragma warning restore 0169

		public virtual unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/method[@name='isCancel' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.ReturnCode']]"
		[Register ("isCancel", "(Lcom/arthenica/ffmpegkit/ReturnCode;)Z", "")]
		public static unsafe bool IsCancel (global::Com.Arthenica.Ffmpegkit.ReturnCode? returnCode)
		{
			const string __id = "isCancel.(Lcom/arthenica/ffmpegkit/ReturnCode;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((returnCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnCode).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (returnCode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='ReturnCode']/method[@name='isSuccess' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.ReturnCode']]"
		[Register ("isSuccess", "(Lcom/arthenica/ffmpegkit/ReturnCode;)Z", "")]
		public static unsafe bool IsSuccess (global::Com.Arthenica.Ffmpegkit.ReturnCode? returnCode)
		{
			const string __id = "isSuccess.(Lcom/arthenica/ffmpegkit/ReturnCode;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((returnCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnCode).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (returnCode);
			}
		}

	}
}
