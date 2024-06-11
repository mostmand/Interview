public class User {
    private String name;
    private String email;

    public User(String name, String email) {
        this.name = name;
        this.email = email;
    }

    public String getDetails() {
        return "Name: " + name + ", Email: " + email;
    }

    public void saveToDatabase() {
        // Simulate saving to a database
        System.out.println("Saving " + name + " to the database");
    }

    public void sendEmail(String message) {
        // Simulate sending an email
        System.out.println("Sending email to " + email + ": " + message);
    }

    public static void main(String[] args) {
        User user = new User("John Doe", "john.doe@example.com");
        System.out.println(user.getDetails());
        user.saveToDatabase();
        user.sendEmail("Welcome to our platform!");
    }
}
