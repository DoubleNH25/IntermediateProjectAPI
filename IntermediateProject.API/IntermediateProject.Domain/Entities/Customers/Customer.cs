using IntermediateProject.Domain.Abstraction.Entity;
using IntermediateProject.Domain.Entities.Customers.DTOs;
using IntermediateProject.Domain.Entities.Customers.Events;
using IntermediateProject.Domain.Entities.Customers.ValueObject;
using IntermediateProject.Domain.Entities.Invoices;
using IntermediateProject.Domain.Entities.Invoices.Events;
using IntermediateProject.Domain.Entities.Shared;

namespace IntermediateProject.Domain.Entities.Customers
{
	public sealed class Customer : BaseEntity
	{
		private Customer(
			Title title,
			Address address,
			Money balance)
		{
			Title = title;
			Address = address;
			Balance = balance;
		}

		private Customer() { }

		public Title Title { get; private set; } = null!;

		public Address Address { get; private set; } = null!;

		public Money Balance { get; private set; } = null!;


		public ICollection<Invoice> Invoices { get; private set; } = null!;

		public static Customer Create(CreateCustomerDto dto)
		{
			var customer = new Customer(
				new Title(dto.Title),
				new Address(
					dto.FirstLineAddress,
					dto.SecondLineLineAddress,
					dto.Postcode,
					dto.City,
					dto.Country),
				new Money(0));

			customer.RaiseDomainEvent(
				new CustomerCreatedDomainEvent(customer.Id));

			return customer;
		}

		public void Update(UpdateCustomerDto dto)
		{
			Title = new Title(dto.Title);
			Address = new Address(
					dto.FirstLineAddress,
					dto.SecondLineLineAddress,
					dto.Postcode,
					dto.City,
					dto.Country);
		}

		public void IncreaseBalance(Money invoiceAmount)
			=> Balance = new Money(
				Balance.Value + invoiceAmount.Value);

		public void DecreaseBalance(Money invoiceAmount)
			=> Balance = new Money(
				Balance.Value - invoiceAmount.Value);

		public void RemoveInvoice(Invoice invoice)
		{
			Invoices.Remove(invoice);

			RaiseDomainEvent(new InvoiceRemovedDomainEvent(
				Id,
				invoice.TotalBalance));
		}

	}
}
