interface PhoneInterface
{
	void Call();
}

interface PlugInterface
{
	void Charge ();
}

interface CamaraInterface
{
	void TakeAPhoto ();
}

class Camara10MP : CamaraInterface
{
	float Megapixels = 10.0;

	void TakeAPhoto()
	{
		// Take A Photo Logic
	}
}

class Camara5MP : CamaraInterface
{
	float Megapixels = 5.0;

	void TakeAPhoto()
	{
		// Take A Photo Logic
	}
}

class USAPlug : PlugInterface
{
	string PlugType = "USA";

	void Charge()
	{
		// Charge Logic
	}
}

class EUPlug : PlugInterface
{
	string PlugType = "EU";

	void Charge()
	{
		// Charge Logic
	}
}

class Samsung : PhoneInterface
{
	string OS;

	void Call()
	{
		// Call Logic
	}

class Iphone : PhoneInterface
{
	string OS;
	
	void Call()
	{
		// Call Logic
	}
}

class PhoneBuilder
{
	object Phone;
	object Camara;
	object Plug;

	// Constructor
	public PhoneBuilder(PhoneInterface PhoneI, PlugInterface PlugI, CamaraInterface CamaraI)
	{
		this.Phone = PhoneI;
		this.Camara = CamaraI;
		this.Plug = PlugI;
	}
}