
-- =============================================
-- Author:      <Author, Marit Irene Sandanger,>
-- Create Date: <Create Date, 12.10.2018, >
-- Description: <Description, The procedure inserts all fields available into the dbo.Persontabell, >
-- =============================================

alter procedure dbo.spPersontabell_InsertPerson
	@IDnumber int, @FirstName nvarchar(50), @SecondName nvarchar(50) = '', @Lastname nvarchar(50),
	@Address1 nvarchar(50) = '', @Address2 nvarchar(50) = '', @Address3 nvarchar(50) = '',
	@Address4 nvarchar(50) = '', @Address5 nvarchar(50) = '', @Zipcode1 int = '',
	@Zipcode2 int = '', @Zipcode3 int = '', @Zipcode4 int = '', @Zipcode5 int = '', 
	@ZipCodeArea1 nvarchar(50) = '', @ZipCodeArea2 nvarchar(50) = '', @ZipCodeArea3 nvarchar(50) = '',
	@ZipCodeArea4 nvarchar(50) = '', @ZipCodeArea5 nvarchar(50) = '', @Email1 nvarchar(50) = '',
	@Email2 nvarchar(50) = '', @Email3 nvarchar(50) = '', @Email4 nvarchar(50) = '', @Email5 nvarchar(50) = ''
as
begin
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    set nocount on;

	insert into dbo.Persontabell (ID, Fornavn, Mellomnavn, Etternavn, Adresse1, Adresse2, Adresse3, Adresse4, Adresse5,
		Postnummer1, Postnummer2, Postnummer3, Postnummer4, Postnummer5, Poststed1, Poststed2,
		Poststed3, Poststed4, Poststed5, Email1, Email2, Email3, Email4, Email5)
	select @IDnumber, @FirstName, @SecondName, @Lastname, @Address1, @Address2, @Address3, @Address4, @Address5,
		@Zipcode1, @Zipcode2, @Zipcode3, @Zipcode4, @Zipcode5, @ZipCodeArea1, @ZipCodeArea2, @ZipCodeArea3,
		@ZipCodeArea4, @ZipCodeArea5, @Email1, @Email2, @Email3, @Email4, @Email5

end



