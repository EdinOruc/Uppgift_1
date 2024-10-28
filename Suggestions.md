# Lösningsförslag

## 1. Command-line arguments.
Ange Port-namnen som inparametrar

> \BatteryAndGPSComponentSimulator.exe COM1

> \VehicleComController.exe COM2

```CSharp
.. void Main(string[] args)
{
	:
	// Test if input arguments were suplied.
	    if (args.Length == 0)
        {
            Console.WriteLine("Please enter a port name as an argument.");
            return 1;
        }

	PortName = args[0] 
```

### Arguments under debug

	Gäller för båda projekt
	
	* Högerklicka projekt filen
	* Välj properties
	* Under Degug öppna "Launch Profiles" > "Command line arguments"
	* Ange Port-namnet: COM1
	
	
  -> Properties folder skapas och launchSettings.json
	( JavaScript Object Notation )

```json
{
  "profiles": {
    "VehicleComController": {
      "commandName": "Project",
      "commandLineArgs": "COM1"
    }
  }
}
```	
	
## 2. Using configurations files. json

	Under projektet skapa en ny fil. En .json fil
	
	appsettings.json
	
```json

    "COMSettings": {
        "PortName": "COM1"
    }
	
```	

	Att använda inställningarna som definierats i appsettings.json-filen i din C#-applikation kräver att du läser in filen och tolkar dess innehåll.

  Installera NuGet packages: 
        Microsoft.Extensions.Configuration
				Microsoft.Extensions.Configuration.json
		
	* För att kunna öppna rätt konfigurations fil så måste den kopieras till output folder där exe filen finns. 
	- Välj .json filen och Högerklicka
	- Under properties välj 'Copy to Output Directory'
	
Bygg och kör lösning.	
