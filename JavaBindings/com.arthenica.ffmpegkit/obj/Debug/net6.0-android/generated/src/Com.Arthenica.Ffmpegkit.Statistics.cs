using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/Statistics", DoNotGenerateAcw=true)]
	public partial class Statistics : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/Statistics", typeof (Statistics));

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

		protected Statistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/constructor[@name='Statistics' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='long'] and parameter[6][@type='int'] and parameter[7][@type='double'] and parameter[8][@type='double']]"
		[Register (".ctor", "(JIFFJIDD)V", "")]
		public unsafe Statistics (long sessionId, int videoFrameNumber, float videoFps, float videoQuality, long size, int time, double bitrate, double speed) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JIFFJIDD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (sessionId);
				__args [1] = new JniArgumentValue (videoFrameNumber);
				__args [2] = new JniArgumentValue (videoFps);
				__args [3] = new JniArgumentValue (videoQuality);
				__args [4] = new JniArgumentValue (size);
				__args [5] = new JniArgumentValue (time);
				__args [6] = new JniArgumentValue (bitrate);
				__args [7] = new JniArgumentValue (speed);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetBitrate);
			return cb_getBitrate;
		}

		static double n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Bitrate;
		}
#pragma warning restore 0169

		static Delegate? cb_setBitrate_D;
#pragma warning disable 0169
		static Delegate GetSetBitrate_DHandler ()
		{
			if (cb_setBitrate_D == null)
				cb_setBitrate_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetBitrate_D);
			return cb_setBitrate_D;
		}

		static void n_SetBitrate_D (IntPtr jnienv, IntPtr native__this, double bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Bitrate = bitrate;
		}
#pragma warning restore 0169

		public virtual unsafe double Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()D", "GetGetBitrateHandler")]
			get {
				const string __id = "getBitrate.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setBitrate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBitrate", "(D)V", "GetSetBitrate_DHandler")]
			set {
				const string __id = "setBitrate.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSessionId);
			return cb_getSessionId;
		}

		static long n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SessionId;
		}
#pragma warning restore 0169

		static Delegate? cb_setSessionId_J;
#pragma warning disable 0169
		static Delegate GetSetSessionId_JHandler ()
		{
			if (cb_setSessionId_J == null)
				cb_setSessionId_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetSessionId_J);
			return cb_setSessionId_J;
		}

		static void n_SetSessionId_J (IntPtr jnienv, IntPtr native__this, long sessionId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SessionId = sessionId;
		}
#pragma warning restore 0169

		public virtual unsafe long SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()J", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setSessionId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSessionId", "(J)V", "GetSetSessionId_JHandler")]
			set {
				const string __id = "setSessionId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate? cb_setSize_J;
#pragma warning disable 0169
		static Delegate GetSetSize_JHandler ()
		{
			if (cb_setSize_J == null)
				cb_setSize_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetSize_J);
			return cb_setSize_J;
		}

		static void n_SetSize_J (IntPtr jnienv, IntPtr native__this, long size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Size = size;
		}
#pragma warning restore 0169

		public virtual unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSize", "(J)V", "GetSetSize_JHandler")]
			set {
				const string __id = "setSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getSpeed;
#pragma warning disable 0169
		static Delegate GetGetSpeedHandler ()
		{
			if (cb_getSpeed == null)
				cb_getSpeed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetSpeed);
			return cb_getSpeed;
		}

		static double n_GetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Speed;
		}
#pragma warning restore 0169

		static Delegate? cb_setSpeed_D;
#pragma warning disable 0169
		static Delegate GetSetSpeed_DHandler ()
		{
			if (cb_setSpeed_D == null)
				cb_setSpeed_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetSpeed_D);
			return cb_setSpeed_D;
		}

		static void n_SetSpeed_D (IntPtr jnienv, IntPtr native__this, double speed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Speed = speed;
		}
#pragma warning restore 0169

		public virtual unsafe double Speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getSpeed' and count(parameter)=0]"
			[Register ("getSpeed", "()D", "GetGetSpeedHandler")]
			get {
				const string __id = "getSpeed.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setSpeed", "(D)V", "GetSetSpeed_DHandler")]
			set {
				const string __id = "setSpeed.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTime);
			return cb_getTime;
		}

		static int n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Time;
		}
#pragma warning restore 0169

		static Delegate? cb_setTime_I;
#pragma warning disable 0169
		static Delegate GetSetTime_IHandler ()
		{
			if (cb_setTime_I == null)
				cb_setTime_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTime_I);
			return cb_setTime_I;
		}

		static void n_SetTime_I (IntPtr jnienv, IntPtr native__this, int time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Time = time;
		}
#pragma warning restore 0169

		public virtual unsafe int Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()I", "GetGetTimeHandler")]
			get {
				const string __id = "getTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTime", "(I)V", "GetSetTime_IHandler")]
			set {
				const string __id = "setTime.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getVideoFps;
#pragma warning disable 0169
		static Delegate GetGetVideoFpsHandler ()
		{
			if (cb_getVideoFps == null)
				cb_getVideoFps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetVideoFps);
			return cb_getVideoFps;
		}

		static float n_GetVideoFps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.VideoFps;
		}
#pragma warning restore 0169

		static Delegate? cb_setVideoFps_F;
#pragma warning disable 0169
		static Delegate GetSetVideoFps_FHandler ()
		{
			if (cb_setVideoFps_F == null)
				cb_setVideoFps_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetVideoFps_F);
			return cb_setVideoFps_F;
		}

		static void n_SetVideoFps_F (IntPtr jnienv, IntPtr native__this, float videoFps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.VideoFps = videoFps;
		}
#pragma warning restore 0169

		public virtual unsafe float VideoFps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getVideoFps' and count(parameter)=0]"
			[Register ("getVideoFps", "()F", "GetGetVideoFpsHandler")]
			get {
				const string __id = "getVideoFps.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setVideoFps' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setVideoFps", "(F)V", "GetSetVideoFps_FHandler")]
			set {
				const string __id = "setVideoFps.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getVideoFrameNumber;
#pragma warning disable 0169
		static Delegate GetGetVideoFrameNumberHandler ()
		{
			if (cb_getVideoFrameNumber == null)
				cb_getVideoFrameNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoFrameNumber);
			return cb_getVideoFrameNumber;
		}

		static int n_GetVideoFrameNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.VideoFrameNumber;
		}
#pragma warning restore 0169

		static Delegate? cb_setVideoFrameNumber_I;
#pragma warning disable 0169
		static Delegate GetSetVideoFrameNumber_IHandler ()
		{
			if (cb_setVideoFrameNumber_I == null)
				cb_setVideoFrameNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoFrameNumber_I);
			return cb_setVideoFrameNumber_I;
		}

		static void n_SetVideoFrameNumber_I (IntPtr jnienv, IntPtr native__this, int videoFrameNumber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.VideoFrameNumber = videoFrameNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoFrameNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getVideoFrameNumber' and count(parameter)=0]"
			[Register ("getVideoFrameNumber", "()I", "GetGetVideoFrameNumberHandler")]
			get {
				const string __id = "getVideoFrameNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setVideoFrameNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoFrameNumber", "(I)V", "GetSetVideoFrameNumber_IHandler")]
			set {
				const string __id = "setVideoFrameNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getVideoQuality;
#pragma warning disable 0169
		static Delegate GetGetVideoQualityHandler ()
		{
			if (cb_getVideoQuality == null)
				cb_getVideoQuality = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetVideoQuality);
			return cb_getVideoQuality;
		}

		static float n_GetVideoQuality (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.VideoQuality;
		}
#pragma warning restore 0169

		static Delegate? cb_setVideoQuality_F;
#pragma warning disable 0169
		static Delegate GetSetVideoQuality_FHandler ()
		{
			if (cb_setVideoQuality_F == null)
				cb_setVideoQuality_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetVideoQuality_F);
			return cb_setVideoQuality_F;
		}

		static void n_SetVideoQuality_F (IntPtr jnienv, IntPtr native__this, float videoQuality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.VideoQuality = videoQuality;
		}
#pragma warning restore 0169

		public virtual unsafe float VideoQuality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='getVideoQuality' and count(parameter)=0]"
			[Register ("getVideoQuality", "()F", "GetGetVideoQualityHandler")]
			get {
				const string __id = "getVideoQuality.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Statistics']/method[@name='setVideoQuality' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setVideoQuality", "(F)V", "GetSetVideoQuality_FHandler")]
			set {
				const string __id = "setVideoQuality.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
