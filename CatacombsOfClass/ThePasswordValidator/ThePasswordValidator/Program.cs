using ThePasswordValidator;
MessageOutput MO = new();
MO.DisplayMessage("Hello Adventurer, we need you to enter a valid password");
while (true)
{
    string word = MO.ReadMessage();
    PasswordValidator PWV = new(word);
    PWV.ValidatePassword();
};
