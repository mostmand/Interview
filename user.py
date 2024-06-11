class User:
    def __init__(self, name, email):
        self.name = name
        self.email = email

    def get_details(self):
        return f"Name: {self.name}, Email: {self.email}"

    def save_to_database(self):
        # Simulate saving to a database
        print(f"Saving {self.name} to the database")

    def send_email(self, message):
        # Simulate sending an email
        print(f"Sending email to {self.email}: {message}")

# Example usage
user = User("John Doe", "john.doe@example.com")
print(user.get_details())
user.save_to_database()
user.send_email("Welcome to our platform!")
