import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
import smtplib

data = pd.read_csv({CSVpath}, header=None, names=['Timestamp', 'Voltage', 'Current', 'BreakerStatus']) # Replace {CSVpath} with the path to the CSV file
print(data.columns)
data['Timestamp'] = pd.to_datetime(data['Timestamp'])

data = data[['Timestamp', 'Voltage', 'Current', 'BreakerStatus']]
print(data.head())  # Inspect the first few rows of data

data.dropna(inplace=True)

voltage = data['Voltage']
current = data['Current']

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

def send_email_alert(subject, message):
    sender_email = "your_email@gmail.com"  # Replace with your email
    receiver_email = "receiver_email@gmail.com"  # Replace with the recipient's email
    password = "your_password"  # Use app-specific password if needed

    try:
        with smtplib.SMTP("smtp.gmail.com", 587) as server:
            server.starttls()
            server.login(sender_email, password)
            email_message = f"Subject: {subject}\n\n{message}"
            server.sendmail(sender_email, receiver_email, email_message)
            print("Email alert sent!")
    except Exception as e:
        print(f"Failed to send email: {e}")

if voltage.min() < 200:
    print("ALERT: Voltage Drop Detected!")
    send_email_alert("Voltage Drop Alert", f"Voltage dropped to {voltage.min} V.")
if current.max() > 15:
    print("ALERT: Current Spike Detected!")
    send_email_alert("Current Spike Alert", f"Current spiked to {current.max} A.")

 