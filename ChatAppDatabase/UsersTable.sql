CREATE TABLE Users
(
	UserID int PRIMARY KEY IDENTITY,
	FirstName varchar(30),
	LastName varchar(30),
	Email varchar(50),
	UserName varchar(30),
	Password varchar(30),
	IsOnline bit,
	CreatedDate Datetime,
	ModifiedDate Datetime
);

Create Table UserMessages
(
	SenderName varchar(30),
	ReceiverName varchar(30),
	Message nvarchar(max),
	SentDate Datetime
)