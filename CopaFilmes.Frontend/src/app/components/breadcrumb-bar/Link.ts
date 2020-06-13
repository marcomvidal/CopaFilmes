export class Link {
    label: string;
    url: string;
    isCurrentPage: boolean;

    constructor(label: string, url: string, isCurrentPage: boolean) {
        this.label = label;
        this.url = url;
        this.isCurrentPage = isCurrentPage;
    }
}