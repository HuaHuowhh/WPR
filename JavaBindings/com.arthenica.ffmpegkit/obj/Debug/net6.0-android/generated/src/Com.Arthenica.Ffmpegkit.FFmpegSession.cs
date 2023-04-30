using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/FFmpegSession", DoNotGenerateAcw=true)]
	public partial class FFmpegSession : global::Com.Arthenica.Ffmpegkit.AbstractSession, global::Com.Arthenica.Ffmpegkit.ISession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/FFmpegSession", typeof (FFmpegSession));

		internal static new IntPtr class_ref {
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

		protected FFmpegSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/constructor[@name='FFmpegSession' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		public unsafe FFmpegSession (string[]? arguments) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arguments);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/constructor[@name='FFmpegSession' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)V", "")]
		public unsafe FFmpegSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/constructor[@name='FFmpegSession' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.StatisticsCallback']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;)V", "")]
		public unsafe FFmpegSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (statisticsCallback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/constructor[@name='FFmpegSession' and count(parameter)=5 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.StatisticsCallback'] and parameter[5][@type='com.arthenica.ffmpegkit.LogRedirectionStrategy']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V", "")]
		public unsafe FFmpegSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback, global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? logRedirectionStrategy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				__args [4] = new JniArgumentValue ((logRedirectionStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logRedirectionStrategy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (statisticsCallback);
				global::System.GC.KeepAlive (logRedirectionStrategy);
			}
		}

		static Delegate? cb_getAllStatistics;
#pragma warning disable 0169
		static Delegate GetGetAllStatisticsHandler ()
		{
			if (cb_getAllStatistics == null)
				cb_getAllStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllStatistics);
			return cb_getAllStatistics;
		}

		static IntPtr n_GetAllStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Statistics>.ToLocalJniHandle (__this.AllStatistics);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Statistics>? AllStatistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='getAllStatistics' and count(parameter)=0]"
			[Register ("getAllStatistics", "()Ljava/util/List;", "GetGetAllStatisticsHandler")]
			get {
				const string __id = "getAllStatistics.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Statistics>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCompleteCallback;
#pragma warning disable 0169
		static Delegate GetGetCompleteCallbackHandler ()
		{
			if (cb_getCompleteCallback == null)
				cb_getCompleteCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCompleteCallback);
			return cb_getCompleteCallback;
		}

		static IntPtr n_GetCompleteCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CompleteCallback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? CompleteCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='getCompleteCallback' and count(parameter)=0]"
			[Register ("getCompleteCallback", "()Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;", "GetGetCompleteCallbackHandler")]
			get {
				const string __id = "getCompleteCallback.()Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isFFmpeg;
#pragma warning disable 0169
		static Delegate GetIsFFmpegHandler ()
		{
			if (cb_isFFmpeg == null)
				cb_isFFmpeg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFFmpeg);
			return cb_isFFmpeg;
		}

		static bool n_IsFFmpeg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFmpeg;
		}
#pragma warning restore 0169

		public override unsafe bool IsFFmpeg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='isFFmpeg' and count(parameter)=0]"
			[Register ("isFFmpeg", "()Z", "GetIsFFmpegHandler")]
			get {
				const string __id = "isFFmpeg.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isFFprobe;
#pragma warning disable 0169
		static Delegate GetIsFFprobeHandler ()
		{
			if (cb_isFFprobe == null)
				cb_isFFprobe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFFprobe);
			return cb_isFFprobe;
		}

		static bool n_IsFFprobe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFprobe;
		}
#pragma warning restore 0169

		public override unsafe bool IsFFprobe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='isFFprobe' and count(parameter)=0]"
			[Register ("isFFprobe", "()Z", "GetIsFFprobeHandler")]
			get {
				const string __id = "isFFprobe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isMediaInformation;
#pragma warning disable 0169
		static Delegate GetIsMediaInformationHandler ()
		{
			if (cb_isMediaInformation == null)
				cb_isMediaInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMediaInformation);
			return cb_isMediaInformation;
		}

		static bool n_IsMediaInformation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMediaInformation;
		}
#pragma warning restore 0169

		public override unsafe bool IsMediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='isMediaInformation' and count(parameter)=0]"
			[Register ("isMediaInformation", "()Z", "GetIsMediaInformationHandler")]
			get {
				const string __id = "isMediaInformation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getLastReceivedStatistics;
#pragma warning disable 0169
		static Delegate GetGetLastReceivedStatisticsHandler ()
		{
			if (cb_getLastReceivedStatistics == null)
				cb_getLastReceivedStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLastReceivedStatistics);
			return cb_getLastReceivedStatistics;
		}

		static IntPtr n_GetLastReceivedStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LastReceivedStatistics);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.Statistics? LastReceivedStatistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='getLastReceivedStatistics' and count(parameter)=0]"
			[Register ("getLastReceivedStatistics", "()Lcom/arthenica/ffmpegkit/Statistics;", "GetGetLastReceivedStatisticsHandler")]
			get {
				const string __id = "getLastReceivedStatistics.()Lcom/arthenica/ffmpegkit/Statistics;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getStatistics;
#pragma warning disable 0169
		static Delegate GetGetStatisticsHandler ()
		{
			if (cb_getStatistics == null)
				cb_getStatistics = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatistics);
			return cb_getStatistics;
		}

		static IntPtr n_GetStatistics (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Statistics>.ToLocalJniHandle (__this.Statistics);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Statistics>? Statistics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='getStatistics' and count(parameter)=0]"
			[Register ("getStatistics", "()Ljava/util/List;", "GetGetStatisticsHandler")]
			get {
				const string __id = "getStatistics.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Statistics>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getStatisticsCallback;
#pragma warning disable 0169
		static Delegate GetGetStatisticsCallbackHandler ()
		{
			if (cb_getStatisticsCallback == null)
				cb_getStatisticsCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatisticsCallback);
			return cb_getStatisticsCallback;
		}

		static IntPtr n_GetStatisticsCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.StatisticsCallback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? StatisticsCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='getStatisticsCallback' and count(parameter)=0]"
			[Register ("getStatisticsCallback", "()Lcom/arthenica/ffmpegkit/StatisticsCallback;", "GetGetStatisticsCallbackHandler")]
			get {
				const string __id = "getStatisticsCallback.()Lcom/arthenica/ffmpegkit/StatisticsCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IStatisticsCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_addStatistics_Lcom_arthenica_ffmpegkit_Statistics_;
#pragma warning disable 0169
		static Delegate GetAddStatistics_Lcom_arthenica_ffmpegkit_Statistics_Handler ()
		{
			if (cb_addStatistics_Lcom_arthenica_ffmpegkit_Statistics_ == null)
				cb_addStatistics_Lcom_arthenica_ffmpegkit_Statistics_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddStatistics_Lcom_arthenica_ffmpegkit_Statistics_);
			return cb_addStatistics_Lcom_arthenica_ffmpegkit_Statistics_;
		}

		static void n_AddStatistics_Lcom_arthenica_ffmpegkit_Statistics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_statistics)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var statistics = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Statistics> (native_statistics, JniHandleOwnership.DoNotTransfer);
			__this.AddStatistics (statistics);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='addStatistics' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.Statistics']]"
		[Register ("addStatistics", "(Lcom/arthenica/ffmpegkit/Statistics;)V", "GetAddStatistics_Lcom_arthenica_ffmpegkit_Statistics_Handler")]
		public virtual unsafe void AddStatistics (global::Com.Arthenica.Ffmpegkit.Statistics? statistics)
		{
			const string __id = "addStatistics.(Lcom/arthenica/ffmpegkit/Statistics;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((statistics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statistics).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (statistics);
			}
		}

		static Delegate? cb_getAllStatistics_I;
#pragma warning disable 0169
		static Delegate GetGetAllStatistics_IHandler ()
		{
			if (cb_getAllStatistics_I == null)
				cb_getAllStatistics_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetAllStatistics_I);
			return cb_getAllStatistics_I;
		}

		static IntPtr n_GetAllStatistics_I (IntPtr jnienv, IntPtr native__this, int waitTimeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Statistics>.ToLocalJniHandle (__this.GetAllStatistics (waitTimeout));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegSession']/method[@name='getAllStatistics' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAllStatistics", "(I)Ljava/util/List;", "GetGetAllStatistics_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Statistics>? GetAllStatistics (int waitTimeout)
		{
			const string __id = "getAllStatistics.(I)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (waitTimeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Statistics>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
