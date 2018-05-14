package md5b79e37a911d3471dca1379cf3abf8e6a;


public class CreateButtonActivity
	extends md5b79e37a911d3471dca1379cf3abf8e6a.MainActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Check_Book.CreateButtonActivity, Check Book, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CreateButtonActivity.class, __md_methods);
	}


	public CreateButtonActivity ()
	{
		super ();
		if (getClass () == CreateButtonActivity.class)
			mono.android.TypeManager.Activate ("Check_Book.CreateButtonActivity, Check Book, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
