from pymodbus.server.sync import StartTcpServer
from pymodbus.datastore import ModbusSlaveContext, ModbusServerContext
from pymodbus.datastore import ModbusSequentialDataBlock  # Ensure this import is added
from pymodbus.device import ModbusDeviceIdentification

# Create Modbus data store
store = ModbusSlaveContext(
    di=ModbusSequentialDataBlock(0, [0]*100),
    co=ModbusSequentialDataBlock(0, [0]*100),
    hr=ModbusSequentialDataBlock(0, [10, 20, 30]),  # Example values
    ir=ModbusSequentialDataBlock(0, [0]*100),
)
context = ModbusServerContext(slaves=store, single=True)

# Device identification (optional)
identity = ModbusDeviceIdentification()
identity.VendorName = "PyModbus"
identity.ProductCode = "PM"
identity.VendorUrl = "http://github.com/riptideio/pymodbus/"
identity.ProductName = "PyModbus Server"
identity.ModelName = "PyModbus Server"
identity.MajorMinorRevision = "2.5.3"

# Start the server
StartTcpServer(context, identity=identity, address=("localhost", 502))
