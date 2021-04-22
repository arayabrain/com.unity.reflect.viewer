//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vx_sdk_config_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vx_sdk_config_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vx_sdk_config_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vx_sdk_config_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VivoxCoreInstancePINVOKE.delete_vx_sdk_config_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int num_codec_threads {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_num_codec_threads_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_num_codec_threads_get(swigCPtr);
      return ret;
    } 
  }

  public int num_voice_threads {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_num_voice_threads_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_num_voice_threads_get(swigCPtr);
      return ret;
    } 
  }

  public int num_web_threads {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_num_web_threads_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_num_web_threads_get(swigCPtr);
      return ret;
    } 
  }

  public int render_source_queue_depth_max {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_render_source_queue_depth_max_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_render_source_queue_depth_max_get(swigCPtr);
      return ret;
    } 
  }

  public int render_source_initial_buffer_count {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_render_source_initial_buffer_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_render_source_initial_buffer_count_get(swigCPtr);
      return ret;
    } 
  }

  public int upstream_jitter_frame_count {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_upstream_jitter_frame_count_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_upstream_jitter_frame_count_get(swigCPtr);
      return ret;
    } 
  }

  public int allow_shared_capture_devices {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_allow_shared_capture_devices_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_allow_shared_capture_devices_get(swigCPtr);
      return ret;
    } 
  }

  public int max_logins_per_user {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_max_logins_per_user_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_max_logins_per_user_get(swigCPtr);
      return ret;
    } 
  }

  public string app_id {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_app_id_set(swigCPtr, value);
    } 
    get {
      string ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_app_id_get(swigCPtr);
      return ret;
    } 
  }

  public string cert_data_dir {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_cert_data_dir_set(swigCPtr, value);
    } 
    get {
      string ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_cert_data_dir_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_size_t__p_void pf_malloc_func {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_malloc_func_set(swigCPtr, SWIGTYPE_p_f_size_t__p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_malloc_func_get(swigCPtr);
      SWIGTYPE_p_f_size_t__p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_size_t__p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void__void pf_free_func {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_free_func_set(swigCPtr, SWIGTYPE_p_f_p_void__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_free_func_get(swigCPtr);
      SWIGTYPE_p_f_p_void__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_size_t__p_void pf_realloc_func {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_realloc_func_set(swigCPtr, SWIGTYPE_p_f_p_void_size_t__p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_realloc_func_get(swigCPtr);
      SWIGTYPE_p_f_p_void_size_t__p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_size_t__p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_size_t_size_t__p_void pf_calloc_func {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_calloc_func_set(swigCPtr, SWIGTYPE_p_f_size_t_size_t__p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_calloc_func_get(swigCPtr);
      SWIGTYPE_p_f_size_t_size_t__p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_size_t_size_t__p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_size_t_size_t__p_void pf_malloc_aligned_func {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_malloc_aligned_func_set(swigCPtr, SWIGTYPE_p_f_size_t_size_t__p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_malloc_aligned_func_get(swigCPtr);
      SWIGTYPE_p_f_size_t_size_t__p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_size_t_size_t__p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void__void pf_free_aligned_func {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_free_aligned_func_set(swigCPtr, SWIGTYPE_p_f_p_void__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_free_aligned_func_get(swigCPtr);
      SWIGTYPE_p_f_p_void__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void__void(cPtr, false);
      return ret;
    } 
  }

  public int reserved {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_reserved_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_reserved_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void job_queue_handle {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_job_queue_handle_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_job_queue_handle_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_void_size_t__int pf_queue_job_sync {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_queue_job_sync_set(swigCPtr, SWIGTYPE_p_f_p_void_p_void_size_t__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_queue_job_sync_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_void_size_t__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_void_size_t__int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_void_size_t__int pf_queue_job_async {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_queue_job_async_set(swigCPtr, SWIGTYPE_p_f_p_void_p_void_size_t__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_queue_job_async_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_void_size_t__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_void_size_t__int(cPtr, false);
      return ret;
    } 
  }

  public long processor_affinity_mask {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_processor_affinity_mask_set(swigCPtr, value);
    } 
    get {
      long ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_processor_affinity_mask_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void callback_handle {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_callback_handle_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_callback_handle_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_enum_vx_log_level_p_q_const__char_p_q_const__char__void pf_logging_callback {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_logging_callback_set(swigCPtr, SWIGTYPE_p_f_p_void_enum_vx_log_level_p_q_const__char_p_q_const__char__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_logging_callback_get(swigCPtr);
      SWIGTYPE_p_f_p_void_enum_vx_log_level_p_q_const__char_p_q_const__char__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_enum_vx_log_level_p_q_const__char_p_q_const__char__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void__void pf_sdk_message_callback {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_sdk_message_callback_set(swigCPtr, SWIGTYPE_p_f_p_void__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_sdk_message_callback_get(swigCPtr);
      SWIGTYPE_p_f_p_void__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void__void(cPtr, false);
      return ret;
    } 
  }

  public vx_log_level initial_log_level {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_initial_log_level_set(swigCPtr, (int)value);
    } 
    get {
      vx_log_level ret = (vx_log_level)VivoxCoreInstancePINVOKE.vx_sdk_config_t_initial_log_level_get(swigCPtr);
      return ret;
    } 
  }

  public int disable_device_polling {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_disable_device_polling_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_disable_device_polling_get(swigCPtr);
      return ret;
    } 
  }

  public int force_capture_silence {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_force_capture_silence_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_force_capture_silence_get(swigCPtr);
      return ret;
    } 
  }

  public int enable_advanced_auto_levels {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_advanced_auto_levels_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_advanced_auto_levels_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void pf_on_audio_unit_started {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_started_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_started_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void pf_on_audio_unit_stopped {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_stopped_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_stopped_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int__void pf_on_audio_unit_after_capture_audio_read {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_after_capture_audio_read_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_after_capture_audio_read_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void pf_on_audio_unit_before_capture_audio_sent {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_before_capture_audio_sent_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_before_capture_audio_sent_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void pf_on_audio_unit_before_recv_audio_mixed {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_mixed_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_mixed_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void pf_on_audio_unit_before_recv_audio_rendered {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_rendered_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_before_recv_audio_rendered_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void(cPtr, false);
      return ret;
    } 
  }

  public int capture_device_buffer_size_intervals {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_capture_device_buffer_size_intervals_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_capture_device_buffer_size_intervals_get(swigCPtr);
      return ret;
    } 
  }

  public int render_device_buffer_size_intervals {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_render_device_buffer_size_intervals_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_render_device_buffer_size_intervals_get(swigCPtr);
      return ret;
    } 
  }

  public int disable_audio_ducking {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_disable_audio_ducking_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_disable_audio_ducking_get(swigCPtr);
      return ret;
    } 
  }

  public int use_access_tokens {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_use_access_tokens_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_use_access_tokens_get(swigCPtr);
      return ret;
    } 
  }

  public int enable_multiparty_text {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_multiparty_text_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_multiparty_text_get(swigCPtr);
      return ret;
    } 
  }

  public int enable_dtx {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_dtx_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_dtx_get(swigCPtr);
      return ret;
    } 
  }

  public uint default_codecs_mask {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_default_codecs_mask_set(swigCPtr, value);
    } 
    get {
      uint ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_default_codecs_mask_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_p_void_p_int_p_p_void_p_int__void pf_on_before_udp_frame_transmitted {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_before_udp_frame_transmitted_set(swigCPtr, SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_p_void_p_int_p_p_void_p_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_before_udp_frame_transmitted_get(swigCPtr);
      SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_p_void_p_int_p_p_void_p_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_p_void_p_int_p_p_void_p_int__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_void_int_p_void_int_int__void pf_on_after_udp_frame_transmitted {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_after_udp_frame_transmitted_set(swigCPtr, SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_void_int_p_void_int_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_after_udp_frame_transmitted_get(swigCPtr);
      SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_void_int_p_void_int_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_enum_vx_udp_frame_type_p_void_int_p_void_int_p_void_int_int__void(cPtr, false);
      return ret;
    } 
  }

  public int enable_fast_network_change_detection {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_fast_network_change_detection_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_fast_network_change_detection_get(swigCPtr);
      return ret;
    } 
  }

  public int use_os_proxy_settings {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_use_os_proxy_settings_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_use_os_proxy_settings_get(swigCPtr);
      return ret;
    } 
  }

  public int enable_persistent_http {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_persistent_http_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_enable_persistent_http_get(swigCPtr);
      return ret;
    } 
  }

  public int preferred_sip_port {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_preferred_sip_port_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_preferred_sip_port_get(swigCPtr);
      return ret;
    } 
  }

  public int default_render_to_receiver {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_default_render_to_receiver_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_default_render_to_receiver_get(swigCPtr);
      return ret;
    } 
  }

  public float mic_makeup_gain {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_mic_makeup_gain_set(swigCPtr, value);
    } 
    get {
      float ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_mic_makeup_gain_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void_p_q_const__char__void pf_on_thread_created {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_thread_created_set(swigCPtr, SWIGTYPE_p_f_p_void_p_q_const__char__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_thread_created_get(swigCPtr);
      SWIGTYPE_p_f_p_void_p_q_const__char__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void_p_q_const__char__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_void__void pf_on_thread_exit {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_thread_exit_set(swigCPtr, SWIGTYPE_p_f_p_void__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_thread_exit_get(swigCPtr);
      SWIGTYPE_p_f_p_void__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_void__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_void__int pf_request_permission_for_network {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_request_permission_for_network_set(swigCPtr, SWIGTYPE_p_f_void__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_request_permission_for_network_get(swigCPtr);
      SWIGTYPE_p_f_void__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_void__int(cPtr, false);
      return ret;
    } 
  }

  public int dynamic_voice_processing_switching {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_dynamic_voice_processing_switching_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_dynamic_voice_processing_switching_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_int__void pf_on_audio_unit_capture_device_status_changed {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_capture_device_status_changed_set(swigCPtr, SWIGTYPE_p_f_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_audio_unit_capture_device_status_changed_get(swigCPtr);
      SWIGTYPE_p_f_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_int__void(cPtr, false);
      return ret;
    } 
  }

  public int never_rtp_timeout_ms {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_never_rtp_timeout_ms_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_never_rtp_timeout_ms_get(swigCPtr);
      return ret;
    } 
  }

  public int lost_rtp_timeout_ms {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_lost_rtp_timeout_ms_set(swigCPtr, value);
    } 
    get {
      int ret = VivoxCoreInstancePINVOKE.vx_sdk_config_t_lost_rtp_timeout_ms_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_int__void pf_on_assert {
    set {
      VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_assert_set(swigCPtr, SWIGTYPE_p_f_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = VivoxCoreInstancePINVOKE.vx_sdk_config_t_pf_on_assert_get(swigCPtr);
      SWIGTYPE_p_f_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_int__void(cPtr, false);
      return ret;
    } 
  }

  public vx_sdk_config_t() : this(VivoxCoreInstancePINVOKE.new_vx_sdk_config_t(), true) {
  }

  public static readonly uint configSize = VivoxCoreInstancePINVOKE.vx_sdk_config_t_configSize_get();
}