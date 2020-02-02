export interface Career {
    id: string;
    companyName?: any;
    positionTitle?: any;
    description?: any;
    startDate: Date;
    endDate?: any;
    lastModified: Date;
    iconCode:string;
    careerContentsInformation: CareerContentsInformation[];
}

export interface CareerContentsInformation {
    id: string;
    careerContentsId: string;
    careerInformation: string;
}