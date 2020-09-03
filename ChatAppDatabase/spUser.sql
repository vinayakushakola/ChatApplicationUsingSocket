
ALTER PROC spAddUser
(
	@FirstName varchar(30),
	@LastName varchar(30),
	@Email varchar(50),
	@UserName varchar(30),
	@Password varchar(30),
	@IsOnline bit,
	@ActionType varchar(30)
)
as
Begin
	BEGIN TRY
	if (@ActionType = 'Registration')
		Begin
			Declare @EmailPresent int
			Declare @UserNamePresent int

			select @EmailPresent = Count(Email) from Users where Email = @Email
			select @UserNamePresent = Count(UserName) from Users where UserName = @UserName 
			if (@EmailPresent > 0)
				Begin
					set @EmailPresent = -1
					return @EmailPresent
				End
			if (@UserNamePresent > 0)
				Begin
					set @UserNamePresent = -2
					return @UserNamePresent
				End
			else
				Begin
					BEGIN TRANSACTION
						Insert Into Users (FirstName,LastName,Email,UserName,Password,IsOnline,CreatedDate,ModifiedDate)
						Values (@FirstName,@LastName,@Email,@UserName,@Password,@IsOnline,GetDate(),GetDate())
					COMMIT TRANSACTION
				End

		End
	END TRY
	BEGIN CATCH
		Rollback Transaction
	END CATCH
End

Alter Proc spLogin
(
	@UserName varchar(30),
	@Password varchar(30),
	@ActionType varchar(30)
)
as
BEGIN
	BEGIN TRY
	if (@ActionType = 'Login')
		Begin
			Declare @UserPresent int

			select @UserPresent = COUNT(UserName) from Users where UserName = @UserName and Password = @Password
			
			if (@UserPresent = 0)
				Begin
					set @UserPresent = -1
					return @UserPresent
				End
			else 
				Begin
					BEGIN TRANSACTION
						Update Users Set IsOnline=1
					COMMIT TRANSACTION
					return @UserPresent
				End
			
		End
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END cATCH
END

CREATE Proc spLogOut
(
	@UserName varchar(30),
	@ActionType varchar(30)
)
as
BEGIN
	BEGIN TRY
	if (@ActionType = 'LogOut')
		Begin
		BEGIN TRANSACTION
			Update Users set IsOnline = 0 Where UserName = @UserName
		COMMIT TRANSACTION
		End
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END cATCH
END

ALTER PROC spListOfOnlineUsers
(
	@UserName varchar(30)
)
AS
BEGIN
	Select FirstName From Users where IsOnline = 1 and UserName != @UserName
END

CREATE PROC spAddSentMessageDetails
(
	@SenderName varchar(30),
	@ReceiverName varchar(30),
	@Message nvarchar(max)
)
AS
BEGIN
	BEGIN TRY
	If Exists(Select UserName From Users Where UserName = @SenderName)
	Begin
		BEGIN TRANSACTION
			Insert Into UserMessages (SenderName,ReceiverName,Message,SentDate)
			Values (@Sendername,@ReceiverName,@Message,GetDate())
		COMMIT TRANSACTION
	End
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

ALTER PROC spGetUserMessages
(
	@SenderName varchar(30),
	@ReceiverName varchar(30)
)
AS
BEGIN 
	Select *
	From UserMessages
	Where (SenderName = @SenderName or SenderName = @ReceiverName) And (ReceiverName = @ReceiverName or ReceiverName = @SenderName)
END
spGetUserMessages 'ravi_u', 'vinayak_u'
