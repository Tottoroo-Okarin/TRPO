using System;

namespace lab1
{
	public class A
	{
		
	}

	public class B : A
	{
		protected Object o1;

		public B(Object o1)
		{
			this.o1 = o1;
		}
	}

	public class C : B
	{
		protected Object o2, o3;
	
		public C(Object o1, Object o2, Object o3)
		{
			this.o1 = o1;
			this.o2 = o2;
			this.o3 = o3;
		}
	}

	public class Main
	{
		Object a1 = new A();
		Object a2 = new A();
		Object a3 = new A();
		Object b1 = new B(a2);
		Object c1 = new C(b1, a1, a2);

	}

}

