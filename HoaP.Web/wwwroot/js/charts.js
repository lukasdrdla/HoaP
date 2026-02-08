window.chartInterop = {
    instances: {},

    renderLineChart: function (canvasId, labels, datasets) {
        this.destroyIfExists(canvasId);
        var ctx = document.getElementById(canvasId);
        if (!ctx) return;

        var colors = ['#0d6efd', '#198754', '#ffc107', '#dc3545'];
        var chartDatasets = datasets.map(function (ds, i) {
            return {
                label: ds.label,
                data: ds.data,
                borderColor: colors[i % colors.length],
                backgroundColor: colors[i % colors.length] + '20',
                tension: 0.3,
                fill: true
            };
        });

        this.instances[canvasId] = new Chart(ctx, {
            type: 'line',
            data: { labels: labels, datasets: chartDatasets },
            options: {
                responsive: true,
                plugins: { legend: { position: 'top' } },
                scales: { y: { beginAtZero: true } }
            }
        });
    },

    renderBarChart: function (canvasId, labels, data, label) {
        this.destroyIfExists(canvasId);
        var ctx = document.getElementById(canvasId);
        if (!ctx) return;

        var colors = ['#0d6efd', '#198754', '#ffc107', '#dc3545', '#6f42c1', '#0dcaf0'];

        this.instances[canvasId] = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labels,
                datasets: [{
                    label: label || '',
                    data: data,
                    backgroundColor: labels.map(function (_, i) { return colors[i % colors.length]; })
                }]
            },
            options: {
                responsive: true,
                plugins: { legend: { display: false } },
                scales: { y: { beginAtZero: true } }
            }
        });
    },

    renderPieChart: function (canvasId, labels, data) {
        this.destroyIfExists(canvasId);
        var ctx = document.getElementById(canvasId);
        if (!ctx) return;

        var colors = ['#0d6efd', '#198754', '#ffc107', '#dc3545', '#6f42c1', '#0dcaf0', '#fd7e14', '#20c997'];

        this.instances[canvasId] = new Chart(ctx, {
            type: 'doughnut',
            data: {
                labels: labels,
                datasets: [{
                    data: data,
                    backgroundColor: colors.slice(0, labels.length)
                }]
            },
            options: {
                responsive: true,
                plugins: { legend: { position: 'right' } }
            }
        });
    },

    destroyIfExists: function (canvasId) {
        if (this.instances[canvasId]) {
            this.instances[canvasId].destroy();
            delete this.instances[canvasId];
        }
    }
};
