async function updateQuantityMinus(itemId, change, quantity) {
    if (quantity === 1) {
        removeItem(itemId);
        
    } else {
        const response = await fetch(`/updateQuantity/${itemId}/${change}`, {
            method: 'POST'
        });
        window.location.href = '/Home/Cart';
    }
}
async function updateQuantityPlus(itemId, change) {
    const response = await fetch(`/updateQuantity/${itemId}/${change}`, {
        method: 'POST'
    });
    window.location.href = '/Home/Cart';
}
function removeItem(itemId) {
    Swal.fire({
        title: `Ви впевнені?`,
        text: "Товар буде видалений з кошика",
        showCancelButton: true,
        icon: "warning",
        confirmButtonText: "Так, видалити",
        confirmButtonColor: "#d33",
        cancelButtonColor: "#3085d6",
        cancelButtonText: "Скасувати",
        showLoaderOnConfirm: true,
        preConfirm: async (quantity) => {
            try {
                const response = await fetch(`/deleteItemFromOrder/${itemId}`, {
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
                title: 'Успішно видалено!',
                showConfirmButton: false,
                timer: 1500
            });
            setTimeout(function () {
                window.location.href = '/Home/Cart';
            }, 1500);

        }
    });
}

function placeOrder(itemId) {
    Swal.fire({
        title: `Підтвердити замовлення?`,
        showCancelButton: true,
        confirmButtonText: "Так",
        cancelButtonText: "Скасувати",
        showLoaderOnConfirm: true,
        preConfirm: async (quantity) => {
            try {
                const response = await fetch(`/finishOrder/${itemId}`, {
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
                title: 'Дякуємо за покупку!',
                showConfirmButton: false,
                timer: 1500
            });
            setTimeout(function () {
                window.location.href = '/Home/Index';
            }, 1500);

        }
    });
}