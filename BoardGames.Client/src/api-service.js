import { HttpClient, json } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';
import environment from './environment';

@inject(HttpClient)
export class ApiService {
    constructor(http) {
        http.configure(config => {
            config
                .useStandardConfiguration()
                .withBaseUrl(`${environment.apiUrl}api/`)
                .withDefaults({
                    headers: {
                        'Accept': 'application/json',
                        'Authorization': `Bearer ${environment.apiToken}`
                    }
                });
        });

        this.http = http;
    }

    async delete(id) {
        await this.http.fetch(`games/${id}`, { method: 'DELETE' });
    }

    async getById(id) {
        const response = await this.http.fetch(`games/${id}`);
        return await response.json();
    }

    async getPage(page, pageSize) {
        const response = await this.http.fetch(`games?page=${page}&size=${pageSize}`);
        return await response.json();
    }

    async save(game) {
        const method = game.id ? 'PUT' : 'POST';

        const response = await this.http.fetch(`games${game.id ? '/' + game.id : ''}`, {
            method: method,
            body: json(game)
        });

        return await response.json();
    }
}