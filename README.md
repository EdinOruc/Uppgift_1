# BatteryAndGPSComponentSimulator a Simple Vehicle controller

## Battery control unit
"A simple automotive battery control unit (BCU) that calculates battery states, performs BMS housekeeping, and communicates with the domain controller."

I vårt fall inkluderar det en seriell port för kommunikation med övervakningsenheter som samlar in värden för batteristatus.

För enkelhetens skull övervakar Battery Management System-kontrollern endast spänning.

# GPS unit.

"Collect vehicles current position and send the coordinates via serial port."


# Seriell kommunikation

## COM-portar. 

Seriella portar används alltjämt i exempelvis automationstillämpningar, i industriell automation för kommunikation med PLC (Programmable logic controller) eller undercentraler. Seriella portar är också vanliga i system för driftövervakning.

## Null-modem emulator - Virtual Bridges

Man kan använda sig av "HHD Software Virtual Serial Ports Tools", Free licence.

https://www.hhdsoftware.com


# Multiple startup projects 
To set multiple startup projects
In Solution Explorer, select the solution (the top node).
Choose the solution node's context (right-click) menu and then choose Properties. ...
Expand the Common Properties node, and choose Startup Project.
Choose the Multiple Startup Projects option and set the appropriate actions (Choose Start).
Apply changes to the solution properties.

## Uppgift:

Port-namn för simulator och kontroller ska vara konfigurerbara. 

* I .NET 8 använder du vanligtvis appsettings.json-filen för att hantera konfigurationsinställningar.
	Lägg ett nytt item i varje-projekt, appsettings.json.

	JSON-formatet är lätt att arbeta med, och .NET 8 erbjuder en flexibel och kraftfull mekanism för att läsa och hantera konfigurationer från olika källor, inklusive JSON-filer, miljövariabler och användarspecifika inställningar.

* Installera NuGet-pakett för att kunna hantera Konfigurationer från kod (ConfigurationBuilder).

* Kör om applikationerna med inställningar från filen. Byt port mha emulator, konfigurera om portarna i json-filerna.

* Kör om.

# Mina anteckningar

### Ändrad multiple startup projects In Solution Explorer
