import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns

data = pd.read_csv({CSVpath}, header=None, names=['Timestamp', 'Voltage', 'Current', 'BreakerStatus']) # Replace {CSVpath} with the path to the CSV file
print(data.columns)
data['Timestamp'] = pd.to_datetime(data['Timestamp'])

data = data[['Timestamp', 'Voltage', 'Current', 'BreakerStatus']]
print(data.head())  # Inspect the first few rows of data

data.dropna(inplace=True)

outages = data[data['BreakerStatus'] == False]
outages['Duration'] = outages['Timestamp'].diff().fillna(0)
outages['Duration'] = pd.to_timedelta(outages['Duration'])

def plot_trends(data):
    plt.figure
    sns.lineplot(x='Timestamp', y='Voltage', data=data)
    plt.title('Voltage Trends Over Time')
    plt.xlabel('Timestamp')
    plt.ylabel('Voltage (V)')
    plt.show()

    plt.figure
    sns.lineplot(x='Timestamp', y='Current', data=data)
    plt.title('Current Trends Over Time')
    plt.xlabel('Timestamp')
    plt.ylabel('Current (A)')
    plt.show()

plot_trends(data)

plt.figure
sns.histplot(outages['Duration'].dt.total_seconds(), bins=30, kde=True)
plt.title('Outage Duration Distribution')
plt.xlabel('Duration (Seconds)')
plt.ylabel('Frequency')
plt.show()

