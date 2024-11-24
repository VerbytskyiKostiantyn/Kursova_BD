function showQuantityDialog(itemId, itemName) {
    Swal.fire({
        title: `Введіть кількість для "${itemName}"`,
        input: "number",
        inputAttributes: {
            min: "1",
            step: "1",
            autocomplete: "off"
        },
        inputValue: 1,
        showCancelButton: true,
        confirmButtonText: "До кошика",
        cancelButtonText: "Скасувати",
        showLoaderOnConfirm: true,
        preConfirm: async (quantity) => {
            try {
                const response = await fetch(`/orderItem/${itemId}/${quantity}`, {
                    method: 'POST'
                });
                return true;
            } catch (error) {
                Swal.showValidationMessage(`Помилка: ${error}`);
            }
        },
        allowOutsideClick: () => !Swal.isLoading()
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire({
                icon: 'success',
                title: 'Успішно додано до кошика!',
                showConfirmButton: false,
                timer: 1500
            });
            const countElement = document.getElementById('countValue');
            const number = parseInt(countElement.textContent, 10) + 1;
            if (countElement) {
                countElement.textContent = number;
            }
        }
    });
}