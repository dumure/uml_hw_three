using uml_hw_three;

IUserBuilder userBuilder = new StandardUserBuilder();

var user = userBuilder.AddFirstName("Harry")
                      .AddMiddleName("James")
                      .AddLastName("Potter")
                      .AddBirthday(new DateTime(1980, 7, 31))
                      .AddAddress("Hogwarts")
                      .AddPhone("+88 738-150-51-78")
                      .AddEmail("harry.potter1980@hogwarts.edu.en")
                      .Build();