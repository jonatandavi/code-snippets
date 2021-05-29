import win32com.client

outlook = win32com.client.Dispatch("Outlook.Application").GetNamespace("MAPI")
msg = outlook.OpenSharedItem(r"Your_file_path.msg")

print(msg.SenderName)
print(msg.SenderEmailAddress)
print(msg.SentOn)
print(msg.To)
print(msg.CC)
print(msg.BCC)
print(msg.Subject)
print(msg.Body)