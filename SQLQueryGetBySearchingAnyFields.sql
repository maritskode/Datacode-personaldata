
-- =============================================
-- Author:      <Author, Marit Irene Sandanger,>
-- Create Date: <Create Date, 10.10.2018, >
-- Description: <Description, The procedure searches through the dbo.Persontabell and returns all coloumns of 
--               the person(s) that have any of the fields equal to the @AnyField inparameter
--               The @AnyField inparameter is thought to match the 
--               Fornavn, Etternavn, Adresse, Poststed and Email., >
-- =============================================

create procedure dbo.spPersontabell_GetBySearchingAnyFields
	@AnyField nvarchar(50)
as
begin
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    set nocount on;

	select ID, Fornavn, Mellomnavn, Etternavn, Adresse1, Adresse2, Adresse3, Adresse4, Adresse5,
		Postnummer1, Postnummer2, Postnummer3, Postnummer4, Postnummer5, Poststed1, Poststed2,
		Poststed3, Poststed4, Poststed5, Email1, Email2, Email3, Email4, Email5
	from dbo.Persontabell
	where (Fornavn = @AnyField or Mellomnavn = @AnyField or Etternavn = @AnyField or Adresse1 = @AnyField
			or Adresse2 = @AnyField or Adresse3 = @AnyField or Adresse4 = @AnyField or Adresse5 = @AnyField
			or Poststed1 = @AnyField or Poststed2 = @AnyField or Poststed3 = @AnyField or Poststed4 = @AnyField
			or Poststed5 = @AnyField or Email1 = @AnyField or Email2 = @AnyField or Email3 = @AnyField
			or Email4 = @AnyField or Email5 = @AnyField)
end



