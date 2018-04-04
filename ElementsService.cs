using System.Collections.Generic;

namespace ElectricalSymbols
{
    public class ElementsService
    {
        static public List<ElementGroup> GetElementGroupList()
        {
            return new List<ElementGroup>()
            {
                new ElementGroup("WIRES")
                {
                    new Element() {Name = "Wires", Image = "Wires.jpg", Details = "Represents a conductor that conducts electrical current. Also called a power line or electric line or wire."},
                    new Element() {Name = "Connected Wires", Image = "ConnectedWires.jpg", Details = "Represents the connection of two conductors. Dot shows the junction point."},
                    new Element() {Name = "Unconnected Wires", Image = "UnconnectedWires.jpg", Details = "Represents two unconnected wires/conductors."},
                    new Element() {Name = "Input Bus Line", Image = "InputBusLine.jpg", Details = "Represents a bus for input or incoming data."},
                    new Element() {Name = "Output Bus Line", Image = "OutputBusLine.jpg", Details = "Represents a bus for output or outgoing data."},
                    new Element() {Name = "Terminal", Image = "Terminal.jpg", Details = "Represents start or end point."},
                    new Element() {Name = "Bus Line", Image = "BusLine.jpg", Details = "Represents a number of conductors joined together to form a bus wire."}
                },
                new ElementGroup("SWITCHES")
                {
                    new Element() {Name = "Push Button (Normally Open)", Image = "PushButtonNO.jpg", Details = "This switch is in ON state when the button is pressed otherwise it is in OFF state."},
                    new Element() {Name = "Push Button (Normally Closed)", Image = "PushButtonNC.jpg", Details = "This switch is initially in ON state. This goes to OFF state when it is released."},
                    new Element() {Name = "Spst Switch", Image = "SpstSwitch.jpg", Details = "Single pole single throw is abbreviated as SPST. This acts as ON/OFF switch. Poles define the number of circuits it can be connected to and throws defines the number of positions that a pole connects."},
                    new Element() {Name = "Spdt Switch", Image = "SpdtSwitch.jpg", Details = "Single pole double throw is abbreviated as SPDT. This switch allows the current to flow in any one of the two directions by adjusting its position."},
                    new Element() {Name = "Dpst Switch", Image = "DpstSwitch.jpg", Details = "Double pole single throw is abbreviated as DPST. This switch can drive two circuits at a time."},
                    new Element() {Name = "Dpdt Switch", Image = "DpdtSwitch.jpg", Details = "Double pole double throw is the full form of DPDT. This can connect the four circuits by changing the position."},
                    new Element() {Name = "Relay Switch", Image = "RelaySwitch.jpg", Details = "This represents the relay switch. This can control the AC Loads using the DC voltage applied to the coil."}
                },
                new ElementGroup("SOURCES")
                {
                    new Element() {Name = "AC Supply", Image = "ACSupply.jpg", Details = "This represents AC supply in the circuit."},
                    new Element() {Name = "DC Supply", Image = "DCSupply.jpg", Details = "This represents the DC power supply. It applies DC supply to the circuit."},
                    new Element() {Name = "Constant Current Source", Image = "ConstantCurrentSource.jpg", Details = "The symbol represents an independent current source which delivers constant current."},
                    new Element() {Name = "Controlled Current Source", Image = "ControlledCurrentSource.jpg", Details = "It is a dependent current source. Usually depends on other sources (voltage or current)."},
                    new Element() {Name = "Controlled Voltage Source", Image = "ControlledVoltageSource.jpg", Details = "It is a dependent voltage source. Usually depends on other sources (voltage or current)."},
                    new Element() {Name = "Single Cell Battery", Image = "SingleCellBattery.jpg", Details = "This provides supply to the circuit."},
                    new Element() {Name = "Multi Cell Battery", Image = "MultiCellBattery.jpg", Details = "Combination of multiple single cell batteries or a single large cell battery. The voltage is usually higher."}
                },
                new ElementGroup("WAVE GENERATORS")
                {
                    new Element() {Name = "Sinusoidal Generator", Image = "SinusoidalGenerator.jpg", Details = "Represents sine wave generator."},
                    new Element() {Name = "Pulse Generator", Image = "PulseGenerator.jpg", Details = "Represents pulse or square wave generator."},
                    new Element() {Name = "Triangular Wave", Image = "TriangularWave.jpg", Details = "Represents triangular wave generator."},
                },
                new ElementGroup("GROUND SYMBOLS")
                {
                    new Element() {Name = "Ground", Image = "Ground.jpg", Details = "It is equivalent to theoretical 0V and is used as zero potential reference. It is the potential of perfectly conducting earth."},
                    new Element() {Name = "Signal Ground", Image = "SignalGround.jpg", Details = "It is a reference point from which the signal is measured. There may be several signal grounds in a circuit due to the voltage drops in a circuit."},
                    new Element() {Name = "Chassis Ground", Image = "ChassisGround.jpg", Details = "It acts as a barrier between user and the circuit and prevents electric shock."},
                },
                new ElementGroup("RESISTOR SYMBOLS")
                {
                    new Element() {Name = "Fixed Resistor", Image = "FixedResistor.jpg", Details = "It is a device that opposes the flow of current in a circuit. These two symbols are used to represent fixed resistor."}
                },
                new ElementGroup("VARIABLE RESISTOR")
                {
                    new Element() {Name = "Rheostat", Image = "Rheostat.jpg", Details = "It is a two terminal variable resistor. They are generally used to control the current in the circuit. Generally used in tuning circuits and power control applications like heaters, ovens etc."},
                    new Element() {Name = "Preset", Image = "Preset.jpg", Details = "It is a mini variable resistor. It is also called Trimmer Resistor or Trim Pot. The resistance is adjusted with rotary control present on top of it with the help of a screw driver. They are used to adjust the sensitivity of the circuit like temperature or light."},
                    new Element() {Name = "Thermistor", Image = "Thermistor.jpg", Details = "It is a temperature sensitive resistor. They are used in temperature sensing, current limiting circuits, over-current protection circuits etc."},
                    new Element() {Name = "Varistor", Image = "Varistor.jpg", Details = "It is a Voltage Dependent Resistor. It has non-linear current-voltage characteristics. Generally used in circuit protection from voltage surges and excessive transient voltages."},
                    new Element() {Name = "Magneto Resistor", Image = "MagnetoResistor.jpg", Details = "They are also called as Magnetic Dependent Resistors (MDR). The resistance of magneto resistor varies according to the external magnetic field strength. They are used in electronic compass, ferrous material detection, position sensors etc."},
                    new Element() {Name = "LDR", Image = "LDR.jpg", Details = "They are also called as Photo Resistors. The resistance of LDR varies with the intensity of the light incident on it. They are generally used in light sensing applications."},
                    new Element() {Name = "Tapped Resistor", Image = "TappedResistor.jpg", Details = "A wire-wound type fixed resistor with one or more terminals along its length. Generally used in voltage divider applications."},
                    new Element() {Name = "Attenuator", Image = "Attenuator.jpg", Details = "It is a device used to lower the power of a signal. They are made from simple voltage dividers and hence can be classified in the family of the resistors."},
                    new Element() {Name = "Memristor", Image = "Memristor.jpg", Details = "The resistance of memristor is varied according to the direction of flow of charge. Memristors can be used in signal processing, logic/computation, non-volatile memory etc."}
                },
                new ElementGroup("CAPACITOR SYMBOLS")
                {
                    new Element() {Name = "Non Polarized Capacitor", Image = "NonPolarizedCapacitor.jpg", Details = "Capacitor stores the charge in the form of electrical energy. These two symbols are used for non-polarized capacitor. Non-polarized capacitors are big in size with small capacitance. They can be used in both AC and DC circuits."},
                    new Element() {Name = "Polarized Capacitor", Image = "PolarizedCapacitor.jpg", Details = "Polarized capacitors are small in size but have high capacitance. They are used in DC circuits. They can be used as filters, for bypassing or passing low frequency signals."},
                    new Element() {Name = "Electrolytic Capacitor", Image = "ElectrolyticCapacitor.jpg", Details = "Almost all electrolytic capacitors are polarized and hence used in DC circuits."},
                    new Element() {Name = "Feed Through Capacitor", Image = "FeedThroughCapacitor.jpg", Details = "They provide low impedance path to ground for high frequency signals."},
                    new Element() {Name = "Variable Capacitor", Image = "VariableCapacitor.jpg", Details = "The capacitance of the variable capacitor can be adjusted by turning the knob. They are widely used to adjust the frequency , that is for tuning."}
                },
                new ElementGroup("INDUCTORS")
                {
                    new Element() {Name = "Iron Core Inductor", Image = "IronCoreInductor.jpg", Details = "These are used as substitutes to ferrite core inductors. Ferrite core or Ferromagnetic inductors have high permeability and require air gap to reduce it. Iron powdered core inductors have this air gap integrated."},
                    new Element() {Name = "Ferrite Core Inductors", Image = "FerriteCoreInductors.jpg", Details = "Core material, in this type of inductors is made of ferrite material. These are mostly used to suppress the interference of electromagnetic waves."},
                    new Element() {Name = "Center Tapped Inductors", Image = "CenterTappedInductors.jpg", Details = "These are used in coupling of signals."},
                    new Element() {Name = "Variable Inductors", Image = "VariableInductors.jpg", Details = "Movable ferrite magnetic core variable inductors are most common. The inductance is varied by sliding the core in or out of the coil."}
                },
                new ElementGroup("DIODES")
                {
                    new Element() {Name = "Pn Junction Diode", Image = "PnJunctionDiode.jpg", Details = "A PN junction diode allows the current to flow only in forward bias condition. These diodes can be used in clipping and clamping circuits , as rectifiers in dc circuits etc."},
                    new Element() {Name = "Zener Diode", Image = "ZenerDiode.jpg", Details = "In forward bias condition, it acts as normal diode and allows current. It also allows current to flow in reverse bias condition when the voltage reaches a certain break-down point. Generally used in voltage regulator and over voltage protection circuits."},
                    new Element() {Name = "Photodiode", Image = "Photodiode.jpg", Details = "Photodiode detects the light energy and converts it into current or voltage by a mechanism called photoelectric effect. These are used in CD players , Cameras etc."},
                    new Element() {Name = "Led", Image = "Led.jpg", Details = "Light emitting diode is similar to PN junction diode but they emit energy in the form of light instead of heat. These are mostly used in indication , lightening applications."},
                    new Element() {Name = "Varactor Diode", Image = "VaractorDiode.jpg", Details = "Varactor diode is called varicap or variable capacitance diode. The capacitance of this diode varies according to the applied input voltage. This is used in frequency controlled oscillators , frequency multipliers etc."},
                    new Element() {Name = "Shockley Diode", Image = "ShockleyDiode.jpg", Details = "This is a four layer diode. This had fast switching operation and hence is used in switching applications."},
                    new Element() {Name = "Schottky Diode", Image = "SchottkyDiode.jpg", Details = "It represents Schottky diode. It has low forward voltage drop and it can switch rapidly. Used in voltage clamping, rectifiers, reverse current and discharge protection"},
                    new Element() {Name = "Tunnel Diode", Image = "TunnelDiode.jpg", Details = "This is also known as Esaki diode.It can switch very fastly and can perform well in micro wave frequency range. This is used in oscillator circuits and micro wave circuits."},
                    new Element() {Name = "Thyristor", Image = "Thyristor.jpg", Details = "It consists of four layers of alternating P and N materials. They act as bistable switches and are used in circuits where high voltages and currents are involved."},
                    new Element() {Name = "Constant Current Diode", Image = "ConstantCurrentDiode.jpg", Details = "Also called as Current Limiting Diode or Current Regulating Diode. It limits the current to a specified maximum value."},
                    new Element() {Name = "Laser Diode", Image = "LaserDiode.jpg", Details = "The laser diode is similar to light emitting diode. The active region is formed in intrinsic region in PIN structure. Laser diodes find its applications in laser printing, laser scanning etc."}
                },
                new ElementGroup("TRANSISTOR SYMBOLS")
                {
                    new Element() {Name = "NPN", Image = "NPN.jpg", Details = "It is made of combination of P-type semiconductor between two N-type semiconductors. It is switched ON when the base-emitter junction is forward biased. They are commonly used for amplifying and switching applications."},
                    new Element() {Name = "PNP", Image = "PNP.jpg", Details = "It is made of combination of N-type semiconductor between two P-type semiconductors. It is switched ON when the base-emitter junction is reverse biased. These are used for amplifying and switching applications."},
                    new Element() {Name = "N-Channel JFET", Image = "NChannelJFET.jpg", Details = "N-channel JFET is made by n-type silicon bars which form two PN junctions at the side. Majority charge carriers here are electrons."},
                    new Element() {Name = "P-Channel JFET", Image = "PChannelJFET.jpg", Details = "P-Channel JFET is made by p-type silicon bar which forms two PN junctions at the side. Majority charge carriers here are holes."},
                    new Element() {Name = "Enhancement MOSFET", Image = "EnhancementMOSFET.jpg", Details = "The enhancement mode MOSFET has positive gate operation. It induces negative charges into the n-channel and thus number of negative charges increases, enhancing the channel conductivity."},
                    new Element() {Name = "Depletion MOSFET", Image = "DepletionMOSFET.jpg", Details = "The depletion mode has negative gate operation. This decreases the width of the depletion layer."},
                    new Element() {Name = "Phototransistor", Image = "Phototransistor.jpg", Details = "The photo transistor converts the light energy falling on it to its corresponding electrical energy. This can be used in light sensing applications.Base is left disconnected as light is used to enable the flow of current."},
                    new Element() {Name = "Photo Darlington", Image = "PhotoDarlington.jpg", Details = "Photo Darlington Transistor is similar to phototransistor with very high gain and sensitivity"},
                    new Element() {Name = "Darlington Transistor", Image = "DarlingtonTransistor.jpg", Details = "This configuration produces high current gain. They are used in power regulators, output stages of audio amplifiers, display drivers etc."}
                },
                new ElementGroup("LOGIC GATES")
                {
                    new Element() {Name = "And Gate", Image = "AndGate.jpg", Details = "This is the basic gate and it implements logical conjunction. The output of the AND gate is high, only if both the inputs are high otherwise both are low."},
                    new Element() {Name = "Or Gate", Image = "OrGate.jpg", Details = "The OR gate implements logical disjunction.The output is high if any one of the inputs is high."},
                    new Element() {Name = "Nand Gate", Image = "NandGate.jpg", Details = "It is complement of AND gate. The output is low only when both the inputs are high, otherwise it is high."},
                    new Element() {Name = "Nor Gate", Image = "NorGate.jpg", Details = "NOR gate is a not OR gate. Output of this gate is high, if both the inputs are Low, otherwise it is High."},
                    new Element() {Name = "Not Gate", Image = "NotGate.jpg", Details = "Inverter or NOT gate implements logical negation. This gate inverts the input."},
                    new Element() {Name = "Exor", Image = "Exor.jpg", Details = "This gate implements exclusive OR logic. The output of this gate is high ,if both the inputs are different."},
                    new Element() {Name = "Exnor", Image = "Exnor.jpg", Details = "This gate implements negation of EXOR logic. The output of this gate is high , only if the two inputs are identical."},
                    new Element() {Name = "Buffer", Image = "Buffer.jpg", Details = "It is an audio signaling device. Generally used in alarms, timers and for confirmation messages."},
                    new Element() {Name = "Tri-State Buffer", Image = "TriStateBuffer.jpg", Details = "Similar to a normal buffer but with a control signal. In case of active high buffer, it operates normally only when control signal is 1. In case of active low buffer, it operates normally only when control signal is 0."},
                    new Element() {Name = "Flip Flop", Image = "FlipFlop.jpg", Details = "Flip flop is the also a memory element but this is a synchronous device. The figure below shows the basic D-flip-flop."}
                },
                new ElementGroup("AMPLIFIERS")
                {
                    new Element() {Name = "Basic Amplifier", Image = "BasicAmplifier.jpg", Details = "An amplifier is a device that amplifies a relatively small input signal i.e. it increases the power of the signal. They are used in communication systems, audio devices etc"},
                    new Element() {Name = "Operational Amplifier", Image = "OperationalAmplifier.jpg", Details = "Operational Amplifier (Op Amp) is a voltage amplifier with very high gain. The input is differential. They are used in instrumentation devices, signal processing, control systems etc"}
                },
                new ElementGroup("ANTENNA")
                {
                    new Element() {Name = "Antenna", Image = "Antenna.jpg", Details = "This symbol belongs to Aerial or Antenna. It converts electrical power into radio waves. It is used in wireless communication to transmit or receive the signals."},
                    new Element() {Name = "Loop Antenna", Image = "LoopAntenna.jpg", Details = "Loop antenna is named after its loop like shape of wire or other electrical conductor. They are used as receiving antennas in low frequency range."},
                    new Element() {Name = "Dipole Antenna", Image = "DipoleAntenna.jpg", Details = "It is most widely used antenna.Generally used in set-top TV, shortwave transmission and FM receivers."}
                },
                new ElementGroup("TRANSFORMER")
                {
                    new Element() {Name = "Transformer", Image = "Transformer.jpg", Details = "Transformer is the basic element that transfers energy in one circuit to the other circuit through electromagnetic induction. They are generally used in electric power applications to increase or decrease the voltage of AC current."},
                    new Element() {Name = "Iron Core", Image = "IronCore.jpg", Details = "Uses a piece of magnetic material as core. Generally Ferro magnetic metals like iron are used. The core has high permeability and is used to confine the magnetic field."},
                    new Element() {Name = "Center Tapped", Image = "CenterTapped.jpg", Details = "The center tapped transformer has its secondary winding divided into two parts with same number of turns in each part. This results in two individual output voltages across two line ends. Used in rectifier circuits."},
                    new Element() {Name = "Step Up Transformer", Image = "StepUpTransformer.jpg", Details = "The no. of turns in secondary winding is more than that of primary winding. The output voltage is higher than input voltage. Significantly used in inverters."},
                    new Element() {Name = "Step Down Transformer", Image = "StepDownTransformer.jpg", Details = "The no. of turns in secondary winding is less than that of primary winding. The output voltage is lesser than input voltage. It is widely used in low power applications."}
                },
                new ElementGroup("MISCELLANEOUS")
                {
                    new Element() {Name = "Buzzer", Image = "Buzzer.jpg", Details = "This is sound producing device. This produces buzz sound when the voltage is applied."},
                    new Element() {Name = "Loud Speaker", Image = "LoudSpeaker.jpg", Details = "This is also an audio device. The electrical signal is converted into sound signal here."},
                    new Element() {Name = "Light Bulb", Image = "LightBulb.jpg", Details = "The symbol represents the light bulb. The bulb glows when required voltage is applied."},
                    new Element() {Name = "Motor", Image = "Motor.jpg", Details = "This converts the electric energy to mechanical energy."},
                    new Element() {Name = "Fuse", Image = "Fuse.jpg", Details = "Symbol represents the fuse that protects the circuit from over current."},
                    new Element() {Name = "Crystal Oscillator", Image = "CrystalOscillator.jpg", Details = "Used to generate clock signal of very precise frequency."},
                    new Element() {Name = "ADC", Image = "ADC.jpg", Details = "Analog to Digital converter is used convert analog signals (usually voltage) to digital values."},
                    new Element() {Name = "DAC", Image = "DAC.jpg", Details = "Digital to Analog converter is used to convert digital code to analog signals."},
                    new Element() {Name = "Thermocouple", Image = "Thermocouple.jpg", Details = "It is used to measure temperature."}
                }


            };
        }
    }
}