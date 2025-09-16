namespace nilnul.os.proc.thread_.fore_
{
	/// <summary>
	/// some app is not ui app. eg: service.
	/// for such app, a thread, even nonUi, is called foreground in that it's the main thread to interact with Os to coordinate other derived threads;
	/// </summary>
	interface INonUi { }


}
