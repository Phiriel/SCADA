from pyModbusTCP.server import ModbusServer
import time
import random

# Create and start Modbus server
server = ModbusServer("127.0.0.1", 502, no_block=True)
server.start()
print("Modbus server running...")
v_values = [10, 20, 50, 120, 140, 180, 240]
i_values = [1, 2, 3, 30, 35, 40, 45, 50]
i = 1

file_path = r'C:\\Users\\phili\\source\\repos\\SCADA\\DataLog.csv'


# Open the file in write mode, which clears the file content
with open(file_path, 'w') as file:
    file.write('')

try:
    while True:
        # Simulate changing values for registers
        voltage = random.choice(v_values)  # Simulate voltage
        current = random.choice(i_values)   # Simulate current
        if voltage < 100:
            breaker_status = False
        else:
            breaker_status = True

        # Write values to Modbus DataBank
        server.data_bank.set_holding_registers(0, [voltage])  # Voltage at 40001
        server.data_bank.set_holding_registers(1, [current])  # Current at 40002
        server.data_bank.set_coils(0, [breaker_status])  # Breaker at 00001
        print(f"{i} Voltage: {voltage}, Current: {current}, Breaker: {breaker_status}")
        i += 1
        time.sleep(1)

except KeyboardInterrupt:
    print("Stopping server...")
    server.stop()
