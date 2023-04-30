using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/FFprobeKit", DoNotGenerateAcw=true)]
	public partial class FFprobeKit : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/FFprobeKit", typeof (FFprobeKit));

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

		protected FFprobeKit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("execute", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? Execute (string? command)
		{
			const string __id = "execute.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_command);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeWithArguments' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("executeWithArguments", "([Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteWithArguments (string[]? arguments)
		{
			const string __id = "executeWithArguments.([Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arguments);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback'] and parameter[3][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFprobeSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? completeCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFprobeSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFprobeSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMediaInformation", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformation (string? path)
		{
			const string __id = "getMediaInformation.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getMediaInformation", "(Ljava/lang/String;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformation (string? path, int waitTimeout)
		{
			const string __id = "getMediaInformation.(Ljava/lang/String;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (waitTimeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformationAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback']]"
		[Register ("getMediaInformationAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformationAsync (string? path, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback)
		{
			const string __id = "getMediaInformationAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformationAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='int']]"
		[Register ("getMediaInformationAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformationAsync (string? path, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, int waitTimeout)
		{
			const string __id = "getMediaInformationAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue (waitTimeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformationAsync' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='java.util.concurrent.ExecutorService'] and parameter[5][@type='int']]"
		[Register ("getMediaInformationAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Ljava/util/concurrent/ExecutorService;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformationAsync (string? path, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Java.Util.Concurrent.IExecutorService? executorService, int waitTimeout)
		{
			const string __id = "getMediaInformationAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Ljava/util/concurrent/ExecutorService;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				__args [4] = new JniArgumentValue (waitTimeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformationAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback'] and parameter[3][@type='java.util.concurrent.ExecutorService']]"
		[Register ("getMediaInformationAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformationAsync (string? path, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "getMediaInformationAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformationFromCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMediaInformationFromCommand", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformationFromCommand (string? command)
		{
			const string __id = "getMediaInformationFromCommand.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_command);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='getMediaInformationFromCommandAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='int']]"
		[Register ("getMediaInformationFromCommandAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.MediaInformationSession? GetMediaInformationFromCommandAsync (string? command, global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, int waitTimeout)
		{
			const string __id = "getMediaInformationFromCommandAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;I)Lcom/arthenica/ffmpegkit/MediaInformationSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue (waitTimeout);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformationSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='listFFprobeSessions' and count(parameter)=0]"
		[Register ("listFFprobeSessions", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.FFprobeSession>? ListFFprobeSessions ()
		{
			const string __id = "listFFprobeSessions.()Ljava/util/List;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.FFprobeSession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFprobeKit']/method[@name='listMediaInformationSessions' and count(parameter)=0]"
		[Register ("listMediaInformationSessions", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.MediaInformationSession>? ListMediaInformationSessions ()
		{
			const string __id = "listMediaInformationSessions.()Ljava/util/List;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.MediaInformationSession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
