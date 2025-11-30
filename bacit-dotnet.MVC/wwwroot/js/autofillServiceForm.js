// /wwwroot/js/autofillServiceForm.js
document.addEventListener("DOMContentLoaded", () => {
    const btn = document.getElementById("autofillServiceForm");
    if (!btn) return;

    btn.addEventListener("click", (e) => {
        e.preventDefault();

        const today = new Date();
        const isoToday = today.toISOString().substring(0, 10); // yyyy-MM-dd

        const data = {
            Customer: "Testkunde AS",
            DateReceived: isoToday,
            Address: "Testveien 123, 9010 Tromsø",
            Email: "test.kunde@example.com",
            OrderNumber: "123456789",
            Phone: "12345678",
            ProductType: "Vinsj",
            Year: "2020",
            Service: "Årlig service",
            Warranty: "Ingen garanti",
            SerialNumber: "1234567890",
            Agreement: "Avtalt service og funksjonstest.",
            RepairDescription: "Skiftet vaier, smurt trommel, kontrollert brems.",
            UsedParts: "1x Vaier, 1x Bremsesko",
            WorkHours: "2",
            CompletionDate: isoToday,
            ReplacedPartsReturned: "Nei",
            ShippingMethod: "Hentes av kunde",
            CustomerSignature: "Test Kunde",
            RepairerSignature: "Test Reparatør"
        };

        // Fyll alle felter basert på name-attributtet (som asp-for genererer)
        Object.entries(data).forEach(([name, value]) => {
            const field = document.querySelector(`[name="${name}"]`);
            if (!field) return;

            if (field.tagName === "SELECT") {
                // Velg option hvis den finnes
                const option = Array.from(field.options)
                    .find(o => o.value === value || o.text === value);
                if (option) {
                    field.value = option.value;
                }
            } else {
                field.value = value;
            }
        });
    });
});
