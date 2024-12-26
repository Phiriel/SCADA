from pyModbusTCP.server import ModbusServer
import time
import random

# Create and start Modbus server
server = ModbusServer("127.0.0.1", 502, no_block=True)
server.start()
print("Modbus server running...")

try:
    while True:
        # Simulate changing values for registers
        voltage = random.randint(210, 240)  # Simulate voltage
        current = random.randint(10, 30)   # Simulate current
        breaker_status = random.choice([True, False])  # Breaker ON/OFF

        # Write values to Modbus DataBank
        server.data_bank.set_holding_registers(0, [voltage])  # Voltage at 40001
        server.data_bank.set_holding_registers(1, [current])  # Current at 40002
        server.data_bank.set_coils(0, [breaker_status])  # Breaker at 00001

        print(f"Voltage: {voltage}, Current: {current}, Breaker: {breaker_status}")
        time.sleep(1)

except KeyboardInterrupt:
    print("Stopping server...")
    server.stop()
